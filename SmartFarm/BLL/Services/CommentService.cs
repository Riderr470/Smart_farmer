using AutoMapper;
using BLL.DTOs;
using DAL.EF;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CommentService
    {
        public static CommentDto AddComment(CommentDto comment)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<CommentDto, Comment>();
                c.CreateMap<Comment, CommentDto>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Comment>(comment);
            var rt = DataAccessFactory.CommentAccess().Add(data);
            if (rt != null)
            {
                return mapper.Map<CommentDto>(rt);
            }
            return null;
        }
        public static List<CommentDto> Get()
        {
            var data = DataAccessFactory.CommentAccess().Get();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Comment, CommentDto>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<CommentDto>>(data);
        }
        public static CommentDto Get(int id)
        {
            var data = DataAccessFactory.CommentAccess().Get(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Comment, CommentDto>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<CommentDto>(data);
        }
        
    }
}
