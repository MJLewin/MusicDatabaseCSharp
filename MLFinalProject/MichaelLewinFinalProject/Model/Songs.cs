using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MichaelLewinFinalProject.Model
{
    [Table("songs")]
    public partial class Songs
    {
        [Key]
        [Column("song_id")]
        public int SongId { get; set; }
        [Required]
        [Column("song_title")]
        [StringLength(50)]
        public string SongTitle { get; set; }
        [Column("artist_id")]
        public int ArtistId { get; set; }
        [Column("album_id")]
        public int AlbumId { get; set; }
        [Column("length_in_seconds")]
        public int LengthInSeconds { get; set; }
        [Column("user_comment", TypeName = "text")]
        public string UserComment { get; set; }
        [Column("highest_billboard_rank")]
        public int? HighestBillboardRank { get; set; }
        [Column("date_of_highest_rank", TypeName = "date")]
        public DateTime? DateOfHighestRank { get; set; }
        [Required]
        [Column("song_writer")]
        [StringLength(500)]
        public string SongWriter { get; set; }

        [ForeignKey(nameof(AlbumId))]
        [InverseProperty(nameof(Albums.Songs))]
        public virtual Albums Album { get; set; }
        [ForeignKey(nameof(ArtistId))]
        [InverseProperty(nameof(Artists.Songs))]
        public virtual Artists Artist { get; set; }
    }
}
