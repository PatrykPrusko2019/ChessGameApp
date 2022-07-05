
namespace ChessGameApp.MusicOfWinner
{
    class PlaySound
    {
        private System.Media.SoundPlayer player;
        public PlaySound(string path)
        {
            player = new System.Media.SoundPlayer();
            player.SoundLocation = path;
        }

        public void PlaySong()
        {
            player.Load();
            player.Play();  
        }

    }
}

