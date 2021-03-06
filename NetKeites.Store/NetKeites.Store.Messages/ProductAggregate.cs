﻿using System;
using System.Collections.Generic;

namespace NetKeites.Store.Messages
{
    public class ProductAggregate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<ReviewSummary> Reviews { get; set; }
    }
}
