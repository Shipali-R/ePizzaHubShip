﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Items.Response
{
    public class GetItemsResponseModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal UnitPrice { get; set; }

        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }

        public int ItemTypeId { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
