﻿/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

namespace Common.DTO
{
    public class MeasuredValue<T>
    {
        public MeasuredValue(T value, string uom)
        {
            Value = value;
            UnitOfMeasure = uom;
        }

        public T Value { get; }
        public string UnitOfMeasure { get; }
    }
}
