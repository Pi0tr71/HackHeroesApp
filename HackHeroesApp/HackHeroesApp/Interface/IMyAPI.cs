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

    [Headers("Authorization: Bearer")]
    public interface IMyAPIGR
    {
        [Post("/statistics/getRanking")]
        Task<GRPost> SubmitPost([Body] GRPost post);
    }

    [Headers("Authorization: Bearer")]
    public interface IMyAPIGS
    {
        [Post("/statistics/getStats")]
        Task<GSPost> SubmitPost([Body] GSPost post);
    }
    [Headers("Authorization: Bearer")]
    public interface IMyAPIGT
    {
        [Post("/test/getTest")]
        Task<GTPost> SubmitPost([Body] GTPost post);
    }
}

