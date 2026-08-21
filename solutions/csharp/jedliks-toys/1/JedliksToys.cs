class RemoteControlCar
{
    private int _distanceDrive;
    private int _batteryPercentage = 100;
    public static RemoteControlCar Buy()
    {
        var remoteControlCar = new RemoteControlCar();
        return remoteControlCar;
    }

    public string DistanceDisplay()
    {
        return $"Driven {_distanceDrive} meters";
    }

    public string BatteryDisplay()
    {
        if (_batteryPercentage > 0)
        {
            return $"Battery at {_batteryPercentage}%";
        }
        return "Battery empty";
    }

    public void Drive()
    {
        if (_batteryPercentage > 0)
        {
            _distanceDrive += 20;
            _batteryPercentage -= 1;
        }
    }
}
