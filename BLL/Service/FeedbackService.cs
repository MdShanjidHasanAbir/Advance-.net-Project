using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Model.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class FeedbackService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Feedback, FeedbackDTO>();
                cfg.CreateMap<FeedbackDTO, Feedback>();
                cfg.CreateMap<Feedback, TeacherFeedbackDTO>();
                cfg.CreateMap<Teacher, TeacherDTO>();
                
            });
            return new Mapper(config);
        }
        public static List<FeedbackDTO> Get()
        {
            var data = DataAccessFactory.FeedbackData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Feedback, FeedbackDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<FeedbackDTO>>(data);
            return mapped;
        }
        public static FeedbackDTO Get(int id)
         {
             var data = DataAccessFactory.FeedbackData().Read(id);
             var cfg = new MapperConfiguration(c =>
             {
                 c.CreateMap<Feedback, FeedbackDTO>();

             });
             var mapper = new Mapper(cfg);
             var mapped = mapper.Map<FeedbackDTO>(data);
             return mapped;
         }

     

        public static List<FeedbackDTO> SearchByTitle(string name)
        {
            

        var repo = DataAccessFactory.FeedbackFeatures();
            var data = repo.SearchByTitle(name);
            return GetMapper().Map<List<FeedbackDTO>>(data);


        }


        public static List<FeedbackDTO> SearchByCatagory(string catagory)
        {

            var repo = DataAccessFactory.FeedbackFeatures();
            var data = repo.SearchByCatagory(catagory);
            return GetMapper().Map<List<FeedbackDTO>>(data);


        }


          
        

    }
    }
