using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Model.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class TeacherService
    {
        public static List<TeacherDTO> Get()
        {
            var data = DataAccessFactory.TeacherData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Teacher, TeacherDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map < List<TeacherDTO>>(data);
            return mapped;
        }
        public static TeacherDTO Get(int id) {
            var data = DataAccessFactory.TeacherData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Teacher, TeacherDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<TeacherDTO>(data);
            return mapped;
        }
        public static TeacherFeedbackDTO GetwithFeedbacks(int id)
        {
            var data = DataAccessFactory.TeacherData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Teacher,TeacherFeedbackDTO>();
                c.CreateMap<Feedback, FeedbackDTO>();
            });
             var mapper = new Mapper(cfg);
            var mapped = mapper.Map<TeacherFeedbackDTO>(data);
            return mapped;
        }
    }
}
