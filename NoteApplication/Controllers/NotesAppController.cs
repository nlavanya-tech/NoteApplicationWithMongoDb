using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NoteApplication.BusinessLogics.Interface;
using NoteApplication.Entities;
using NoteApplication.Models;

namespace NoteApplication.Controllers
{
    public class NotesAppController : Controller
    {
        //creating instance of service notes

        private readonly INoteService _service;
        //private InMemoryConnection DbContext;
        public NotesAppController(INoteService service)
        {
            _service = service;
        }

        //Get view For Addnew Notes
        public IActionResult AddNewNotes()
        {
            throw new NotImplementedException();
            //return View();
        }

        //In this method getting Data from view and sending to service to store in DB
        [HttpPost]
        public async Task<ActionResult> SubmitNote(Notes notes)
        {
            throw new NotImplementedException();
        }

        //In this method Getting All Notes from service and sending to view
        [HttpGet]
        public async Task<ActionResult> GetAllNotes()
        {
            throw new NotImplementedException();
        }

        //In this method Getting All Status Notes from service and sending to view
        [HttpGet]
        public async Task<ActionResult> GetAllNoteStatus()
        {
            throw new NotImplementedException();
        }

        //In This method getting perticular note note to update from view and sending to service 
        [HttpPut]
        public async Task<ActionResult> UpdateNotes(Notes notes)
        {
            throw new NotImplementedException();
        }

        //In This method getting perticular note to delete from view and sending to service 
        [HttpDelete]
        public async Task<ActionResult> DeleteNotes(Notes notes)
        {
            throw new NotImplementedException();
        }
         
    }
}