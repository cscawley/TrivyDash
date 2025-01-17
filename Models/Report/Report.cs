﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrivyDash.Models
{
    public class Report
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public int SchemaVersion { get; set; }
        [Required(ErrorMessage = "No Artifact Name")]
        public string? ArtifactName { get; set; }
        [Required(ErrorMessage = "No Artifact Type")]
        public string? ArtifactType { get; set; }
        internal string? _MetaData { get; set; }
        internal string? _Result { get; set; }
        [NotMapped]
        public MetaData? Metadata 
        {
            get { return _MetaData == null ? null : JsonConvert.DeserializeObject<MetaData>(_MetaData); }
            set { _MetaData = JsonConvert.SerializeObject(value); } 
        }
        [NotMapped]
        public List<Result>? Results
        {
            get { return _Result == null ? null : JsonConvert.DeserializeObject<List<Result>>(_Result); }
            set { _Result = JsonConvert.SerializeObject(value); }
        }
    }
}
