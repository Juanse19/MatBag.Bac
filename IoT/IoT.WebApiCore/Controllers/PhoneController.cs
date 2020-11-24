/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Common.Entities;
using Common.WebApiCore;
using Common.WebApiCore.Controllers;
using IoT.Entities.System;
using IoT.Services.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IoT.WebApiCore.Controllers
{
    [Route("phone")]
    public class PhoneController : BaseApiController
    {
        protected readonly IContactService contactService;
        protected readonly IPhoneCallService phoneCallService;
        protected readonly JwtManager jwtManager;

        public PhoneController(IContactService contactService, IPhoneCallService phoneCallService, JwtManager jwtManager)
        {
            this.contactService = contactService;
            this.phoneCallService = phoneCallService;
            this.jwtManager = jwtManager;
        }

        [HttpGet]
        [Route("contacts")]
        public async Task<IActionResult> ContactsAll(string searchText = null, int pageNumber = 1, int pageSize = 10)
        {
            var contacts = await contactService.GetAllContacts(new ContactFilter(searchText, pageNumber, pageSize));
            return Ok(contacts);
        }

        [HttpGet]
        [Route("recent-calls")]
        public async Task<IActionResult> RecentCalls(int pageNumber = 1, int pageSize = 10)
        {
            var calls = await phoneCallService.GetRecentCalls(new BaseFilter(pageNumber, pageSize));
            return Ok(calls);
        }

        [HttpGet]
        [Route("contacts/{contactId:int}/photo")]
        [AllowAnonymous]
        public async Task<IActionResult> ContactPhoto(int contactId, string token)
        {
            var user = jwtManager.GetPrincipal(token);
            if (user == null || !user.Identity.IsAuthenticated)
            {
                return Unauthorized();
            }

            var photoContent = await contactService.GetContactPhoto(contactId);

            if (photoContent == null)
            {
                return NoContent();
            }

            return File(photoContent, contentType: "image/png");
        }
    }
}
