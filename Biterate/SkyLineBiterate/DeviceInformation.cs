using Newtonsoft.Json;

namespace SkyLineBiterate;

public class DeviceInformation
{
    public string Device{get;set;}
    public string Model{get;set;}
    public List<NICDescription> NICDescriptions{get;set;}
    
    public string GetSkylineBiterate(string json, int position){
        try{
        var DeviceInformation = JsonConvert.DeserializeObject<DeviceInformation>(json);
        return DeviceInformation.NICDescriptions[position].CalculateBiterate().SkyLineBiterate;
        }catch(Exception){
            throw;
        }
    }
}
public class NICDescription
{
    public string Timestamp{get;set;}
    public string Description{get;set;}
    public string MAC{get;set;}
    public string IP{get;set;}
    public string Rx{get;set;}
    public string Tx{get;set;}
    public string SkyLineBiterate{get;set;}
    public NICDescription CalculateBiterate(){
        SkyLineBiterate = (Convert.ToDouble(Rx)+Convert.ToDouble(Tx)).ToString();
    return this;
    }
}
