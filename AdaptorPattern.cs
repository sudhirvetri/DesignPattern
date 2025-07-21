using System;

using System.Threading;



public interface IMusicPlayer

{

    void Play();

    void Stop();

}



public class CDPlayer : IMusicPlayer

{

    public void Play()

    {

        Console.WriteLine("music playing from CD");

    }

    

    public void Stop()

    {

        Console.WriteLine("music Stopped playing from CD");

    }

}



public class FmPlayer : IMusicPlayer

{

    public void Play()

    {

        Console.WriteLine("music playing from FM player");

    }

    

    public void Stop()

    {

        Console.WriteLine("music Stopped playing from FM player");

    }

}

    







public class MusicSystem

{

    private readonly IMusicPlayer _player;

    public MusicSystem(IMusicPlayer player) 

    { 

        _player = player;

    }

    public void Start() =>  _player.Play();

    public void Stop()  =>  _player.Stop();

    

}



public class Mp3Player

{

    public void StartPlayback()

    {

        Console.WriteLine("Playing MP3 music...");

    }

    public void StopPlayback()

    {

        Console.WriteLine("Stopping MP3 music...");

    }

}



//adaptor



public class Mp3toMusicplayerAdaptor :IMusicPlayer

{

    Mp3Player _mp3;

    

    public Mp3toMusicplayerAdaptor(Mp3Player mp3)

    {

     this._mp3 =mp3;   

    }

    public void Play()

    {

        _mp3.StartPlayback();

    }

    

    public void Stop()

    {

        _mp3.StopPlayback();

    }

}



class Program {

  static void Main() {

    

    //CDPlayer cd = new CDPlayer(); 

    MusicSystem music = new MusicSystem(new FmPlayer());

    

    music.Start();

    Thread.Sleep(2000);

    music.Stop();

    

    music = new MusicSystem(new CDPlayer());

    

    music.Start();

    Thread.Sleep(2000);

    music.Stop();

    

    Mp3toMusicplayerAdaptor mp3 = new Mp3toMusicplayerAdaptor(new Mp3Player());

    music = new MusicSystem(mp3);

     music.Start();

    Thread.Sleep(2000);

    music.Stop();

  }

}
