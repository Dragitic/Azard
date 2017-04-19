using Azard.Common.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Azard.Common.Infrastructure.Commands;
using Azard.Common.Infrastructure.Queries;
using Azard.Common.Models.DomainModels;
using Azard.CustomResult;

namespace Azard.Controllers
{
    [RoutePrefix("api/messeges")]
    public class MessageController : ApiController
    {
        //private readonly IQueryHandler<GetMessagesQuery, MessageController> _getMessageInfoUseCase;
        //private readonly ICommandHandler<AddNewMessageCommand> _addNewMessageUseCase;

        //public MessageController(
        //    IQueryHandler<GetMessagesQuery, MessageController> getMessageInfoUseCase, 
        //    ICommandHandler<AddNewMessageCommand> addNewMessageUseCase)
        //{
        //    _getMessageInfoUseCase = getMessageInfoUseCase;
        //    _addNewMessageUseCase = addNewMessageUseCase;
        //}

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetAllMessegesInfo()
        {
            var result = new List<string> {"akapit pierwszy", "coś tam ciekawego", "foo bar lols xD"};

            //var result = _getMessageInfoUseCase.Handle(query);

            if (result.Count > 0)
                return Ok(result);

            return NotFound();
        }
    }
}
