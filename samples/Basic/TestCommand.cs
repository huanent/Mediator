﻿using Mediator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    public class TestCommand : ICommand<string>
    {
        public int Id { get; set; }
    }
}