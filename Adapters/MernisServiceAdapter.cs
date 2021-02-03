using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;
using MernisServiceReference;

namespace GameProject.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService , KPSPublicSoap 
    {
       
     public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            
            var client1= client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(customer.NationalityId, customer.FirstName.ToUpper(), customer.LastName.ToUpper(),customer.YearOfBirth))).Result.Body.TCKimlikNoDogrulaResult;
            return client1;
        }
        

        public Task<TCKimlikNoDogrulaResponse> TCKimlikNoDogrulaAsync(TCKimlikNoDogrulaRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
