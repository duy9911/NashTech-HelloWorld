using System;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class SampleWebApiContext:DbContext
    {
        public SampleWebApiContext(DbContextOptions<SampleWebApiContext>options)
        :base(options){}
        public DbSet<TaskModel> TaskItems{get;set;}
    }
}