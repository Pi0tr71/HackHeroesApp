﻿using HackHeroesApp.Model;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HackHeroesApp.Interface
{
    public interface IMyAPIReg
    {
        [Post("/users/registration")]
        Task<RegPost> SubmitPost([Body] RegPost post);
    }
    public interface IMyAPILog
    {
        [Post("/users/login")]
        Task<LogPost> SubmitPost([Body] LogPost post);
    }

    [Headers("Authorization: Bearer")]
    public interface IMyAPIToken
    {
        [Post("/users/checkUserToken")]
        Task<TokenPost> SubmitPost([Body] TokenPost post);
    }

    //[Headers("Authorization: Bearer")]
    //public interface IMyAPICourse
    //{
    //    [Post("/users/checkUserToken")]
    //    Task<CoursePost> SubmitPost([Body] CoursePost post);
    //}
}
