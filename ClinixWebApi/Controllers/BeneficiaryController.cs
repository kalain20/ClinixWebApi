using ClinixWebApi.Context;
using ClinixWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinixWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeneficiaryController : ControllerBase
    {
        private AppDbContext _context;

        public BeneficiaryController(AppDbContext context)
        {
            this._context = context;

        }

       
        //public bool AssignBeneficiary(Beneficiary beneficiary, Patient patient)
        //{
        //    var assign = false;
        //    if (patient.PatientState.Equals("maladie"))
        //    {
        //        patient.Beneficiary = beneficiary;
        //        assign = true;
        //    }

        //    return assign;


        //}
    } 
}
