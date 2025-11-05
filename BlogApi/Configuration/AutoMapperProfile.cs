using AutoMapper;
using BlogApi.Dto;
using BlogApi.Models;

namespace BlogApi.Configuration
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            #region Comment
            CreateMap<Comment, CommentDto>().ReverseMap();
            CreateMap<CommentCreateDto, Comment>();
            #endregion

            #region BlogPost
            CreateMap<BlogPost, BlogPostDto>().ReverseMap();
            CreateMap<BlogPostCreateDto, BlogPost>();
            CreateMap<BlogPostPartialDto, BlogPost>().ReverseMap();
            #endregion
        }

    }
}
