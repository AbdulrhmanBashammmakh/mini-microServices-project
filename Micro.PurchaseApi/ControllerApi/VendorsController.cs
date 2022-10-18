using AutoMapper;
using Micro.PurchaseApi.Dtos;
using Micro.PurchaseApi.Models;
using Micro.PurchaseApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Micro.PurchaseApi.ControllerApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorsController : ControllerBase
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;


        public VendorsController(IUnitOfWork context,IMapper mapper)
        {
            _context = context;
            _mapper=mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetItems()
        {
            var vendors = await _context.Vendor.All();
            var vendordtos= _mapper.Map<List<VendorDto>>(vendors);
            return Ok(vendordtos);
        }
        [HttpPost]
        public async Task<ActionResult<VendorDto>> PostItem(VendorDto vendordto)
        {
           
                var vendor = _mapper.Map<Vendor>(vendordto);
                var checking = _context.Vendor.Upsert(vendor);
                if (await checking)
                {
                    try
                    {
                        await _context.CompleteAsync();
                    }
                    catch
                    {
                        throw;
                    }
                }


                return Ok("posted done ");
            }
            
        }
    }

