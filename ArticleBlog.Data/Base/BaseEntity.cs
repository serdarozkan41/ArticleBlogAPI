using Newtonsoft.Json;
using System;

namespace ArticleBlog.Data
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        [JsonIgnore]
        public bool IsActive { get; set; } = true;
        [JsonIgnore]
        public bool IsDelete { get; set; } = false;
        [JsonIgnore]
        public DateTime CreatedDate { get; set; }
        [JsonIgnore]
        public DateTime ModifiedDate { get; set; }
    }
}
