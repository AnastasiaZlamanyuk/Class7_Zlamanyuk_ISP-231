class TV
{
    private int volume = 100;
    public void SetVolume(int newVolume)
    {
        if (newVolume >= 0 && newVolume <= 100)
        {
            volume = newVolume;
            Console.WriteLine($"Громкость: {volume}");
        }
        else
        {
            Console.WriteLine("Громкость должна быть в пределах от 0 до 100");
        }
    }
}
