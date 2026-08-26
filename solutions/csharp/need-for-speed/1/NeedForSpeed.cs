class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    private int _speed;
    private int _batteryDrain;
    private int _distanceDriven;
    private int _batteryPercentage = 100;
    
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this._speed = speed;
        this._batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        if (this._batteryPercentage < this._batteryDrain)
        {
            return true;
        }
        return false;
    }

    public int DistanceDriven()
    {
        return this._distanceDriven;
    }

    public void Drive()
    {
        
        if (!BatteryDrained())
        {
            this._batteryPercentage -= this._batteryDrain;
            this._distanceDriven += this._speed;
        }
    }
    public static RemoteControlCar Nitro()
    {
        var car = new RemoteControlCar(50,4);
        return car;
    }
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    private int _distance;
    public RaceTrack(int distance)
    {
        this._distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (car.DistanceDriven() < this._distance && !car.BatteryDrained())
        {
             car.Drive();   
            
        }
    return car.DistanceDriven() >= this._distance;
    }
    
}
