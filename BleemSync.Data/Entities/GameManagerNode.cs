﻿using ExtCore.Data.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BleemSync.Data.Entities
{
    public enum GameManagerNodeType
    {
        Game = 1,
        Folder
    }

    public class GameManagerNode : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string SortName { get; set; }
        public string Description { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? Players { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public GameManagerNodeType Type { get; set; }
        public virtual GameSystem System { get; set; }
        public virtual List<GameGenre> Genres { get; set; }
        public virtual List<GameMeta> Meta { get; set; }
        public int? ParentId { get; set; }
        public virtual GameManagerNode Parent { get; set; }
        public virtual List<GameManagerNode> Children { get; set; }
    }
}