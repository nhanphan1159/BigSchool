using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BigSchool.Models
{
    public class Following
    {
        [Key]
        [Column(Order = 1)]
        public string FollowerId{ get; set; }
        [Key]
        [Column(Order = 2)]
        public string FolloweeId { set; get; }


        public ApplicationUser Follower { set; get; }
        public ApplicationUser Followee { set; get; }

  

        

    }
}