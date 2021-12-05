//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCHW9.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movie
    {
        public int Movie_Id { get; set; }
        public int director_id { get; set; }
        public string color { get; set; }
        public Nullable<int> num_critic_for_reviews { get; set; }
        public Nullable<int> duration { get; set; }
        public Nullable<int> director_facebook_likes { get; set; }
        public Nullable<int> actor_3_facebook_likes { get; set; }
        public string actor_2_name { get; set; }
        public Nullable<int> actor_1_facebook_likes { get; set; }
        public Nullable<long> gross { get; set; }
        public string genres { get; set; }
        public string actor_1_name { get; set; }
        public string movie_title { get; set; }
        public Nullable<int> num_voted_users { get; set; }
        public Nullable<int> cast_total_facebook_likes { get; set; }
        public string actor_3_name { get; set; }
        public Nullable<int> facenumber_in_poster { get; set; }
        public string plot_keywords { get; set; }
        public string movie_imdb_link { get; set; }
        public Nullable<int> num_user_for_reviews { get; set; }
        public string language { get; set; }
        public string country { get; set; }
        public string content_rating { get; set; }
        public Nullable<long> budget { get; set; }
        public Nullable<int> title_year { get; set; }
        public Nullable<int> actor_2_facebook_likes { get; set; }
        public Nullable<decimal> imdb_score { get; set; }
        public Nullable<decimal> aspect_ratio { get; set; }
        public Nullable<int> movie_facebook_likes { get; set; }
    
        public virtual Director Director { get; set; }
    }
}
