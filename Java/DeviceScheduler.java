import java.util.ArrayList;
import java.util.List;

interface IDevice {
  int getDeviceId();
  String getDeviceName();
  boolean getStatus();
  void turnOn();
  void turnOff();
}

abstract class SmartDeviceBase implements IDevice {
  protected int deviceId;
  protected String deviceName;
  protected boolean isOn;

  public SmartDeviceBase(int deviceId, String deviceName) {
    this.deviceId = deviceId;
    this.deviceName = deviceName;
  }

  public int getDeviceId() {
    return deviceId; 
  }

  public String getDeviceName() {
    return deviceName;
  }

  public boolean getStatus() {
    return isOn;
  }

  public void turnOn() {
    isOn = true;
    log(String.format("Device %s is now ON.", deviceName));
  }

  public void turnOff() {
    isOn = false;
    log(String.format("Device %s is now OFF.", deviceName));
  }

  public void log(String message) {
    System.out.println(message);
  }
}

class SmartLight extends SmartDeviceBase {
  public SmartLight(int deviceId, String deviceName) {
    super(deviceId, deviceName);
  }
}

class Thermostat extends SmartDeviceBase{
  protected int Temperature;
  protected String Unit;

  public Thermostat(int id, String name) {
    super(id, name);
  }

  public void SetTemperature(int temp, String tempUnit)
  {
    Temperature = temp;
    Unit = tempUnit;
  }
}

class Camera extends SmartDeviceBase {
  protected boolean isRecording;

  public Camera(int deviceId, String deviceName) {
    super(deviceId, deviceName);
    isRecording = false;
  }

  public void startRecording() {
    isRecording = true;
    log(String.format("Camera %s started recording.", deviceName));
  }

  public void stopRecording() {
    isRecording = false;
    log(String.format("Camera %s stopped recording.", deviceName));
  }
}

public class DeviceScheduler {
  List<IDevice> devices;

  public DeviceScheduler() {
    devices = new ArrayList<IDevice>();

    devices.add(new SmartLight(1000, "SmartLight Model Bla"));
    devices.add(new Thermostat(1001, "Thermostat Device"));
    devices.add(new Camera(1002, "Custom Camera"));
    // devices.add(new SmartLock(1003, "SmartLock Gen ZZ"));
  }

  public void TurnOnAllDevices() {
  
    for (IDevice device : devices) {
      if (device instanceof IDevice) {
        IDevice d = (IDevice) device;
        if (!d.getStatus()) {
          System.out.println("Turning on device: " + d.getDeviceName());
          d.turnOn();
        }
      }
    }
  }

    public void TurnOffAllDevices() {
  
    for (IDevice device : devices) {
      if (device instanceof IDevice) {
        IDevice d = (IDevice) device;
        if (d.getStatus()) {
          System.out.println("Turning off device: " + d.getDeviceName());
          d.turnOff();
        }
      }
    }
  }

  public static void main(String[] args)
  {
    System.out.println("Device Scheduler Playground!");
    DeviceScheduler scheduler = new DeviceScheduler();
    scheduler.TurnOnAllDevices();
    scheduler.TurnOffAllDevices();

  }
}