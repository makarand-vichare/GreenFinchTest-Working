﻿using CodingTest.ViewModels.Core;

namespace CodingTest.ServiceResponse
{
    public class ResponseResult<VM> : BaseResponseResult
        where VM: BaseViewModel
    {
        public VM ViewModel { get; set; }
    }
}
