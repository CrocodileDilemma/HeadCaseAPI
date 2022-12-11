﻿using Domain.Entities;
using MediatR;

namespace Application.Posts.Commands
{
    public class Update : IRequest<Post>
    {
        public int PostId { get; set; }
        public string? PostContent { get; set; }
    }
}
