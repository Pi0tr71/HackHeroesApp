using HackHeroesApp.Model;
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
}
