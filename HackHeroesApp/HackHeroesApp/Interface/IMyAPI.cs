using HackHeroesApp.Model;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HackHeroesApp.Interface
{
    public interface IMyAPI
    {
        [Post("/posts")]
        Task<PostContent> SubmitPost([Body] PostContent post);
    }
}
