﻿using Microsoft.AspNetCore.Mvc;
using my_books.Data.Services;
using my_books.Data.ViewModels;
using my_books.Exceptions;
using System;

namespace my_books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        private PublishersService _publishersService;
        public PublishersController(PublishersService publishersService)

        {
            _publishersService = publishersService;
        }

        [HttpPost("add-publisher")]
        public IActionResult AddPublisher([FromBody] PublisherVM publisher)
        {
            try
            {
                var newPublisher = _publishersService.AddPublisher(publisher);
                return Created(nameof(AddPublisher), newPublisher);
            }
            catch (PublisherNameException ex)
            {
                return BadRequest($"{ex.Message}, Publisher name: {ex.PublisherName}");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("get-all-publishers")]
        public IActionResult GetAllPublishers()
        {
            var _response = _publishersService.GetAllPublishers();
            return Ok(_response);
        }


        [HttpGet("get-publisher-by-id/{id}")]
        public IActionResult GetPublisherById(int id)
        {

            //throw new Exception("This exception will be handled by middleware");

            var _response = _publishersService.GetPublisherById(id);
            return _response != null ? Ok(_response) : NotFound();
        }


        [HttpGet("get-publisher-books-with-authors/{id}")]
        public IActionResult GetPublisherData(int id)
        {
            var _response = _publishersService.GetPublisherData(id);
            return Ok(_response);
        }

        [HttpDelete("delete-publisher-by-id/{id}")]
        public IActionResult DeletePublisherById(int id)
        {
            try
            {
            _publishersService.DeletePublisherById(id);
            return Ok();
            }
           
            catch (Exception ex)
            {
                return BadRequest(ex.Message);  
            }
            
        }
    }
}

