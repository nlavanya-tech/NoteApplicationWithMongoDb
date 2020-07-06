using Moq;
using NoteApplication.BusinessLogics.Interface;
using NoteApplication.BusinessLogics.Services;
using NoteApplication.BusinessLogics.Services.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NoteApplication.Test.TestCases
{
 public class Exceptional
    {
        private INoteService _services;
        public readonly Mock<INoteRepository> service = new Mock<INoteRepository>();
        static Exceptional()
        {
            if (!File.Exists("../../../../output_exception_revised.txt"))
                try
                {
                    File.Create("../../../../output_exception_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_exception_revised.txt");
                File.Create("../../../../output_exception_revised.txt").Dispose();
            }
        }
        public Exceptional()
        {
            _services = new NoteService(service.Object);
        }
    }
}
