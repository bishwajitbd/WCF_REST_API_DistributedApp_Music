using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MusicService
{
    /// <summary>
    /// Class for organize music data
    /// </summary>

    [DataContract]
    public class Music
    {
        // Private variable for Music class
        private int _id;
        private string _SongName;
        private string _Artist;
        private string _Album;
        private string _ReleaseYear;

        // Getter and setter method of declear variable for public
        [DataMember]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [DataMember]
        public string SongName
        {
            get { return _SongName; }
            set { _SongName = value; }
        }
        [DataMember]
        public string Artist
        {
            get { return _Artist; }
            set { _Artist = value; }
        }

        [DataMember]
        public string Album
        {
            get { return _Album; }
            set { _Album = value; }
        }
        [DataMember]
        public string ReleaseYear
        {
            get { return _ReleaseYear; }
            set { _ReleaseYear = value; }
        }
    }
}
