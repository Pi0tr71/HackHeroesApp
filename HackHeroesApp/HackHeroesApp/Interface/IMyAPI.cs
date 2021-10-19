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

    [Headers("Authorization: Bearer")]
    public interface IMyAPIToken
    {
        [Post("/users/checkUserToken")]
        Task<TokenPost> SubmitPost([Body] TokenPost post);
    }

    [Headers("Authorization: Bearer")]
    public interface IMyAPIQL
    {
        [Post("/queries/continueCourse")]
        Task<QLPost> SubmitPost([Body] QLPost post);
    }

    [Headers("Authorization: Bearer")]
    public interface IMyAPIQID
    {
        [Post("/queries/getQuestionById")]
        Task<QIDPost> SubmitPost([Body] QIDPost post);
    }

    [Headers("Authorization: Bearer")]
    public interface IMyAPIQCA
    {
        [Post("/queries/checkAnswer")]
        Task<QCAPost> SubmitPost([Body] QCAPost post);
    }
}

