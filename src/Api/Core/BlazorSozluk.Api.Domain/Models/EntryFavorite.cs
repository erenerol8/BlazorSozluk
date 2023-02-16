﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSozluk.Api.Domain.Models
{
    public class EntryFavorite : BaseEntity
    {
        public Guid EntryId { get; set; }

        public Guid CreatedById { get; set; }

        public virtual User CreatedUser { get; set; }

        public virtual Entry Entry { get; set; }

    }
}
