using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly SampleWebApiContext _context;
        public TaskController(SampleWebApiContext context)
        {
            _context = context;
        }
        [HttpGet("GetAllTask")]
        public async Task<ActionResult<IEnumerable<TaskModel>>> GetAllTask()
        {
            return await _context.TaskItems.ToListAsync();
        }
        [HttpPost("Create")]
        public IActionResult Create(TaskModel model)
        {
            _context.TaskItems.Add(model);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Create), new { id = model.Id }, model);
        }
        [HttpDelete("DeleteSelectedId")]
        public ActionResult<bool> DeleteSpecificTask(int id)
        {
            var deleteItem = _context.TaskItems.Where(x => x.Id == id).FirstOrDefault();
            if (deleteItem != null)
            {
                _context.TaskItems.Remove(deleteItem);
                return true;
            }
            return false;
        }
        [HttpGet("GetSelectedTask")]
        public ActionResult<IEnumerable<TaskModel>> GetSelectedTask(int id)
        {
            var selectedTask = _context.TaskItems.Where(x => x.Id == id).FirstOrDefault();
            if (selectedTask != null)
            {
                return RedirectToAction("GetSelectedTask", selectedTask);
            }
            return NotFound();
        }
        [HttpPut("Edit")]
        public ActionResult Edit(TaskModel model)
        {
            var editSelectedTask = _context.TaskItems.Where(x => x.Id == model.Id).FirstOrDefault();
            if (editSelectedTask != null)
            {
                _context.TaskItems.Update(model);
                return RedirectToAction("Edit");
            }
            return NotFound();
        }
        [HttpPost("MultipleCreate")]
        public ActionResult MultipleCreate(List<TaskModel> model)
        {
            if (model != null)
            {
                foreach (var item in model)
                {
                    _context.TaskItems.Add(item);

                }
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(GetAllTask));
        }
        [HttpDelete("MultipleDelete")]
        public async Task<ActionResult<bool>> MultipleDelete(List<int> ids)
        {
            for (int i = 0; i < ids.Count; i++)
            {
                if (ids[i]!=0&&ids!=null)
                {
                    var taskList = await _context.TaskItems.Where(r => ids.Contains(r.Id)).ToListAsync();
                    _context.TaskItems.RemoveRange(taskList);
                    await _context.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            return false;
        }

    }
}