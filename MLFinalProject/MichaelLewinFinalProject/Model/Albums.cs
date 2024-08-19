using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MichaelLewinFinalProject.Model
{
    [Table("albums")]
    public partial class Albums
    {
        public Albums()
        {
            Songs = new HashSet<Songs>();
        }

        [Key]
        [Column("album_id")]
        public int AlbumId { get; set; }
        [Required]
        [Column("album_title")]
        [StringLength(50)]
        public string AlbumTitle { get; set; }
        [Column("artist_id")]
        public int ArtistId { get; set; }
        [Required]
        [Column("album_record_label")]
        [StringLength(50)]
        public string AlbumRecordLabel { get; set; }
        [Required]
        [Column("album_genre")]
        [StringLength(20)]
        public string AlbumGenre { get; set; }
        [Column("release_date", TypeName = "date")]
        public DateTime ReleaseDate { get; set; }
        [Column("album_fact", TypeName = "text")]
        public string AlbumFact { get; set; }

        [ForeignKey(nameof(ArtistId))]
        [InverseProperty(nameof(Artists.Albums))]
        public virtual Artists Artist { get; set; }
        [InverseProperty("Album")]
        public virtual ICollection<Songs> Songs { get; set; }
    }
}
