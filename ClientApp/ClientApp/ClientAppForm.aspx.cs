using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientApp
{
    public partial class ClientAppForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        // Button for getting music detail
        protected void btnGetMusic_Click(object sender, EventArgs e)
        {
            try
            {

                MusicService.MusicServiceClient client = new MusicService.MusicServiceClient();

                MusicService.Music music = client.GetMusic(txtSongName.Text);

                txtArtist.Text = music.Artist;
                txtAlbum.Text = music.Album;
                txtReleaseYear.Text = music.ReleaseYear;
                lblMessage.Text = "Music's data retrieved";
            }
            catch (Exception ex)
            {
                txtArtist.Text = null;
                txtAlbum.Text = null;
                txtReleaseYear.Text = null;
                lblMessage.Text = "Service is not working";
            }
        }
    }
}