using AmazonAPI.Data;
using AmazonAPI.Models;
using AmazonAPI.Models.DTO_s;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AmazonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartnerManagementController : ControllerBase
    {
        private readonly WestendAccountsDbContext _context1;
        private readonly ILogger<PartnerManagementController> _logger;

        public PartnerManagementController(WestendAccountsDbContext context1, ILogger<PartnerManagementController> logger)
        {
            _context1 = context1;
            _logger = logger;
        }

        [HttpGet("Partners")]
        public IActionResult Partners()
        {
            try
            {
                var partners = _context1.Partners
                   .OrderByDescending(x => x.PartnerId)
                   .ToList();
                foreach(var item in partners)
                {
                    item.ContactCompany=_context1.ContactCompanies.Where(x=>x.ContactCompanyId==item.ContactCompanyId).FirstOrDefault();
                }
                var options = new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve,
                    MaxDepth = 64 // Increase if needed
                };

                return new JsonResult(partners, options);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "An error occurred while retrieving invoice data" });
            }
        }

        // GET: api/partners/contact-companies
        [HttpGet("contact-companies")]
        public async Task<ActionResult> GetContactCompanies()
        {
            var contactCompanies = await _context1.ContactCompanies
                .Take(200)
           .OrderBy(x => x.CompanyName)
           .ToListAsync();

            return Ok(contactCompanies);
        }

        // POST: api/partners
        [HttpPost("CreatePartner")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreatePartner([FromBody] PartnerCreateDto partnerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var partner = new Partner
            {
                PartnerShipType = partnerDto.PartnerShipType,
                Name = partnerDto.Name,
                Email = partnerDto.Email,
                Phone = partnerDto.Phone,
                Title = partnerDto.Title,
                Address = partnerDto.Address,
                City = partnerDto.City,
                State = partnerDto.State,
                PostalCode = partnerDto.PostalCode,
                Country = partnerDto.Country,
                Website = partnerDto.Website,
                Industry = partnerDto.Industry,
                ContactCompanyId = partnerDto.ContactCompanyID,
                Renewal = partnerDto.Renewal,
                MinDealValue = partnerDto.MinDealValue,
                RegistrationDate =partnerDto.RegistrationDate,
                Notes = partnerDto.Notes,
                ChangedBy = partnerDto.ChangedBy,
                ChangeDate = partnerDto.ChangeDate
            };

            _context1.Partners.Add(partner);
            await _context1.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPartner), new { id = partner.PartnerId }, partner);
        }

        // Helper method for getting a single partner (optional)
        [HttpGet("GetPartner{id}")]
        public async Task<ActionResult> GetPartner(int id)
        {
            var partner = await _context1.Partners.FindAsync(id);
            if (partner == null)
            {
                return NotFound();
            }
            return Ok(partner);
        }

        // GET: api/partners/edit-data/{id}
        [HttpGet("GetPartnerEditData/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> GetPartnerEditData(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid partner ID");
            }

            var partner = await _context1.Partners
                .AsNoTracking() // Add this to prevent tracking and potential circular references
                .FirstOrDefaultAsync(p => p.PartnerId == id);

            if (partner == null)
            {
                return NotFound($"Partner with ID {id} not found");
            }

            var contactCompanies= await _context1.ContactCompanies.Where(x=>x.Status==4).Take(200)
                .OrderByDescending(x => x.CompanyName)
                 .AsNoTracking()
                .ToListAsync();

            partner.ContactCompany = await _context1.ContactCompanies
                .Where(x => x.ContactCompanyId == partner.ContactCompanyId)
                .FirstOrDefaultAsync();

            var contacts = await _context1.PartnerContacts
                .Where(x => x.PartnerId == id)
                .AsNoTracking() // Add this to prevent tracking and potential circular references
                .ToListAsync();

            var trainings = await _context1.PartnerTrainings
                .Where(x => x.PartnerId == id)
                .AsNoTracking() // Add this to prevent tracking and potential circular references
                .ToListAsync();

            var opportunities = await _context1.PartnerOpportunities
                .Where(x => x.PartnerId == id)
                .AsNoTracking() // Add this to prevent tracking and potential circular references
                .ToListAsync();

            var logins = await _context1.PartnerLogins
                .Where(x => x.PartnerId == id)
                .AsNoTracking() // Add this to prevent tracking and potential circular references
                .ToListAsync();

            var editData = new PartnerEditDataDto
            {
                Partner = partner,
                ContactCompanies = contactCompanies,
                Contacts = contacts,
                ContactCount = contacts.Count,
                Trainings = trainings,
                TrainingCount = trainings.Count,
                Opportunities = opportunities,
                OpportunityCount = opportunities.Count,
                Logins = logins,
                LoginCount = logins.Count
            };

            return Ok(editData);
        }

        //// PUT: api/partners/{id}
        //[HttpPut("UpdatePartner{id}")]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //public async Task<IActionResult> UpdatePartner(int id, [FromBody] PartnerUpdateDto partnerDto)
        //{
        //    if (id != partnerDto.PartnerID)
        //    {
        //        return BadRequest("ID mismatch");
        //    }

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var partner = await _context1.Partners.FindAsync(id);
        //    if (partner == null)
        //    {
        //        return NotFound();
        //    }

        //    // Update properties
        //    partner.PartnerShipType = partnerDto.PartnerShipType;
        //    partner.Name = partnerDto.Name;
        //    partner.Email = partnerDto.Email;
        //    partner.Phone = partnerDto.Phone;
        //    partner.Title = partnerDto.Title;
        //    partner.Address = partnerDto.Address;
        //    partner.City = partnerDto.City;
        //    partner.State = partnerDto.State;
        //    partner.PostalCode = partnerDto.PostalCode;
        //    partner.Country = partnerDto.Country;
        //    partner.Website = partnerDto.Website;
        //    partner.Industry = partnerDto.Industry;
        //    partner.ContactCompanyId = partnerDto.ContactCompanyID;
        //    partner.Renewal = partnerDto.Renewal;
        //    partner.MinDealValue = partnerDto.MinDealValue;
        //    partner.RegistrationDate = partnerDto.RegistrationDate;
        //    partner.Notes = partnerDto.Notes;
        //    partner.ChangedBy = partnerDto.ChangedBy;
        //    partner.ChangeDate = partnerDto.ChangeDate;

        //    _context1.Entry(partner).State = EntityState.Modified;

        //    try
        //    {
        //        await _context1.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!PartnerExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // GET: api/partners/contact-details/{id}
        [HttpGet("contact-details/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> GetContactDetails(int id)
        {
            var contact = await _context1.PartnerContacts
                .FirstOrDefaultAsync(x => x.ContactId == id);

            if (contact == null)
            {
                return NotFound();
            }

            return Ok(contact);
        }

        //private bool PartnerExists(int id)
        //{
        //    return _context1.Partners.Any(e => e.PartnerId == id);
        //}

        // GET: api/partners/training-details/{id}
        [HttpGet("training-details/{id}")]
        public async Task<ActionResult> GetTrainingDetails(int id)
        {
            var training = await _context1.PartnerTrainings
                .Include(x => x.Partner)
                .FirstOrDefaultAsync(x => x.TrainingId == id);

            if (training == null)
            {
                return NotFound();
            }

            return Ok(training);
        }

        // GET: api/partners/opportunity-details/{id}
        [HttpGet("opportunity-details/{id}")]
        public async Task<ActionResult> GetOpportunityDetails(int id)
        {
            var opportunity = await _context1.PartnerOpportunities
                .Include(x => x.Partner)
                .FirstOrDefaultAsync(x => x.OpportunityId == id);

            if (opportunity == null)
            {
                return NotFound();
            }

            return Ok(opportunity);
        }

        // GET: api/partners/login-details/{id}
        [HttpGet("login-details/{id}")]
        public async Task<ActionResult> GetLoginDetails(int id)
        {
            var login = await _context1.PartnerLogins
                .Include(x => x.Partner)
                .FirstOrDefaultAsync(x => x.LoginId == id);

            if (login == null)
            {
                return NotFound();
            }

            return Ok(login);
        }

        // PUT: api/partners/partner/{id}
        [HttpPut("EditPartner/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ApiResponse>> EditPartner(int id, [FromBody] PartnerUpdateDto partnerDetails)
        {
            try
            {
                // Check if partnerDetails is null (this handles the "required" error)
                if (partnerDetails == null)
                {
                    return BadRequest(new ApiResponse { Success = false, Message = "Partner details are required" });
                }

                if (id != partnerDetails.PartnerID)
                {
                    return BadRequest(new ApiResponse { Success = false, Message = "ID mismatch" });
                }

                var partner = await _context1.Partners.FindAsync(id);
                if (partner == null)
                {
                    return NotFound(new ApiResponse { Success = false, Message = "Partner not found" });
                }

                // Update properties - use null-coalescing to handle null values appropriately
                partner.Name = partnerDetails.Name ?? partner.Name;
                partner.PartnerShipType = partnerDetails.PartnerShipType ?? partner.PartnerShipType;
                partner.Address = partnerDetails.Address ?? partner.Address;
                partner.Phone = partnerDetails.Phone ?? partner.Phone;
                partner.Title = partnerDetails.Title ?? partner.Title;
                partner.ContactCompanyId = partnerDetails.ContactCompanyID ?? partner.ContactCompanyId;
                partner.City = partnerDetails.City ?? partner.City;
                partner.State = partnerDetails.State ?? partner.State;
                partner.Country = partnerDetails.Country ?? partner.Country;
                partner.PostalCode = partnerDetails.PostalCode ?? partner.PostalCode;
                partner.Email = partnerDetails.Email ?? partner.Email;
                partner.Renewal = partnerDetails.Renewal ?? partner.Renewal;
                partner.RegistrationDate = partnerDetails.RegistrationDate ?? partner.RegistrationDate;
                partner.Website = partnerDetails.Website ?? partner.Website;
                partner.Industry = partnerDetails.Industry ?? partner.Industry;
                partner.MinDealValue = partnerDetails.MinDealValue ?? partner.MinDealValue;
                partner.Notes = partnerDetails.Notes ?? partner.Notes;
                partner.ChangeDate = DateTime.Now;
                partner.ChangedBy = partnerDetails.ChangedBy ?? partner.ChangedBy;

                _context1.Entry(partner).State = EntityState.Modified;
                await _context1.SaveChangesAsync();

                return Ok(new ApiResponse { Success = true, Id = partner.PartnerId });
            }
            catch (DbUpdateConcurrencyException ex)
            {
                _logger.LogWarning(ex, "Concurrency conflict occurred while updating partner {PartnerId}", id);
                return Conflict(new ApiResponse { Success = false, Message = "Concurrency conflict occurred" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating partner {PartnerId}", id);
                return StatusCode(500, new ApiResponse { Success = false, Message = "An error occurred while updating the partner" });
            }
        }

        // PUT: api/partners/contact/{id}
        [HttpPut("EditContact/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ApiResponse>> EditContact(int id, [FromBody] PartnerContact contactDetails)
        {
            try
            {
                if (id != contactDetails.ContactId)
                {
                    return BadRequest(new ApiResponse { Success = false, Message = "ID mismatch" });
                }

                var contact = await _context1.PartnerContacts.FindAsync(id);
                if (contact == null)
                {
                    return NotFound(new ApiResponse { Success = false, Message = "Contact not found" });
                }

                // Update properties
                contact.PartnerId = contactDetails.PartnerId;
                contact.ContactName = contactDetails.ContactName;
                contact.AddressLine1 = contactDetails.AddressLine1;
                contact.Phone = contactDetails.Phone;
                contact.City = contactDetails.City;
                contact.ContactRole = contactDetails.ContactRole;
                contact.Country = contactDetails.Country;
                contact.State = contactDetails.State;
                contact.Email = contactDetails.Email;
                contact.PostalCode = contactDetails.PostalCode;
                contact.Notes = contactDetails.Notes;

                _context1.Entry(contact).State = EntityState.Modified;
                await _context1.SaveChangesAsync();

                return Ok(new ApiResponse { Success = true, Id = contact.PartnerId });
            }
            catch (DbUpdateConcurrencyException ex)
            {
                _logger.LogWarning(ex, "Concurrency conflict occurred while updating contact {ContactId}", id);
                return Conflict(new ApiResponse { Success = false, Message = "Concurrency conflict occurred" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating contact {ContactId}", id);
                return StatusCode(500, new ApiResponse { Success = false, Message = "An error occurred while updating the contact" });
            }
        }

        // PUT: api/partners/training/{id}
        [HttpPut("EditTraining/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ApiResponse>> EditTraining(int id, [FromBody] PartnerTrainingModel trainingDetails)
        {
            try
            {
                if (id != trainingDetails.TrainingID)
                {
                    return BadRequest(new ApiResponse { Success = false, Message = "ID mismatch" });
                }

                var training = await _context1.PartnerTrainings.FindAsync(id);
                if (training == null)
                {
                    return NotFound(new ApiResponse { Success = false, Message = "Training not found" });
                }

                // Update properties
                training.PartnerId = trainingDetails.PartnerID;
                training.TrainingName = trainingDetails.TrainingName;
                training.TrainingType = trainingDetails.TrainingType;
                training.CompletionDate = trainingDetails.CompletionDate;
                training.CertIssuedTo = trainingDetails.CertIssuedTo;
                training.CertificateUploaded = trainingDetails.CertificateUploaded;

                _context1.Entry(training).State = EntityState.Modified;
                await _context1.SaveChangesAsync();

                return Ok(new ApiResponse { Success = true, Id = training.PartnerId });
            }
            catch (DbUpdateConcurrencyException ex)
            {
                _logger.LogWarning(ex, "Concurrency conflict occurred while updating training {TrainingId}", id);
                return Conflict(new ApiResponse { Success = false, Message = "Concurrency conflict occurred" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating training {TrainingId}", id);
                return StatusCode(500, new ApiResponse { Success = false, Message = "An error occurred while updating the training" });
            }
        }

        // PUT: api/partners/opportunity/{id}
        [HttpPut("EditOpportunity/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ApiResponse>> EditOpportunity(int id, [FromBody] PartnerOpportunityModel opportunityDetails)
        {
            try
            {
                if (id != opportunityDetails.OpportunityID)
                {
                    return BadRequest(new ApiResponse { Success = false, Message = "ID mismatch" });
                }

                var opportunity = await _context1.PartnerOpportunities.FindAsync(id);
                if (opportunity == null)
                {
                    return NotFound(new ApiResponse { Success = false, Message = "Opportunity not found" });
                }

                // Update properties
                opportunity.PartnerId = opportunityDetails.PartnerID;
                opportunity.OpportunityName = opportunityDetails.OpportunityName;
                opportunity.OpportunityType = opportunityDetails.OpportunityType;
                opportunity.ProductName = opportunityDetails.ProductName;
                opportunity.SerialNumber = opportunityDetails.SerialNumber;
                opportunity.FortiCareId = opportunityDetails.FortiCareID;
                opportunity.CoTermQuoteId = opportunityDetails.CoTermQuoteID;
                opportunity.TradeUpId = opportunityDetails.TradeUpID;
                opportunity.IsSdwanopportunity = opportunityDetails.IsSDWANOpportunity;
                opportunity.IsOperationalTechnologyOpportunity = opportunityDetails.IsOperationalTechnologyOpportunity;
                opportunity.EstimatedValue = opportunityDetails.EstimatedValue;
                opportunity.StatusId = opportunityDetails.StatusID;
                opportunity.DealRegOot = opportunityDetails.DealRegOOT;
                opportunity.IsRenewalOver9999 = opportunityDetails.IsRenewalOver9999;
                opportunity.FedDeal = opportunityDetails.FedDeal;
                opportunity.TradeIn = opportunityDetails.TradeIn;
                opportunity.DealType = opportunityDetails.DealType;
                opportunity.CreatedDate = DateTime.Now;
                opportunity.CloseDate = DateTime.Now;
                opportunity.Description = opportunityDetails.Description;
                opportunity.Notes = opportunityDetails.Notes;
                opportunity.ChangedBy = opportunityDetails.ChangedBy;

                _context1.Entry(opportunity).State = EntityState.Modified;
                await _context1.SaveChangesAsync();

                return Ok(new ApiResponse { Success = true, Id = opportunity.PartnerId });
            }
            catch (DbUpdateConcurrencyException ex)
            {
                _logger.LogWarning(ex, "Concurrency conflict occurred while updating opportunity {OpportunityId}", id);
                return Conflict(new ApiResponse { Success = false, Message = "Concurrency conflict occurred" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating opportunity {OpportunityId}", id);
                return StatusCode(500, new ApiResponse { Success = false, Message = "An error occurred while updating the opportunity" });
            }
        }

        // PUT: api/partners/login/{id}
        [HttpPut("EditLogin/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ApiResponse>> EditLogin(int id, [FromBody] PartnerLoginModel loginDetails)
        {
            try
            {
                if (id != loginDetails.LoginID)
                {
                    return BadRequest(new ApiResponse { Success = false, Message = "ID mismatch" });
                }

                var login = await _context1.PartnerLogins.FindAsync(id);
                if (login == null)
                {
                    return NotFound(new ApiResponse { Success = false, Message = "Login not found" });
                }

                // Update properties
                login.PartnerId = loginDetails.PartnerID;
                login.Username = loginDetails.Username;
                login.Password = loginDetails.Password;
                login.LoginUrl = loginDetails.LoginURL;

                _context1.Entry(login).State = EntityState.Modified;
                await _context1.SaveChangesAsync();

                return Ok(new ApiResponse { Success = true, Id = login.PartnerId });
            }
            catch (DbUpdateConcurrencyException ex)
            {
                _logger.LogWarning(ex, "Concurrency conflict occurred while updating login {LoginId}", id);
                return Conflict(new ApiResponse { Success = false, Message = "Concurrency conflict occurred" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating login {LoginId}", id);
                return StatusCode(500, new ApiResponse { Success = false, Message = "An error occurred while updating the login" });
            }
        }

        // POST: api/partners/contact
        [HttpPost("CreateContact")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ApiResponse>> CreateContact([FromBody] PartnerContactModel contactDetails)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new ApiResponse { Success = false, Message = "Invalid model state" });
                }

                var partnerContact = new PartnerContact
                {
                    PartnerId = contactDetails.PartnerID,
                    ContactName = contactDetails.ContactName,
                    AddressLine1 = contactDetails.AddressLine1,
                    Phone = contactDetails.Phone,
                    City = contactDetails.City,
                    ContactRole = contactDetails.ContactRole,
                    Country = contactDetails.Country,
                    State = contactDetails.State,
                    Email = contactDetails.Email,
                    PostalCode = contactDetails.PostalCode,
                    Notes = contactDetails.Notes
                };

                _context1.PartnerContacts.Add(partnerContact);
                await _context1.SaveChangesAsync();

                return CreatedAtAction(nameof(GetContactDetails), new { id = partnerContact.ContactId },
                    new ApiResponse { Success = true, Id = partnerContact.PartnerId, Message = "Contact created successfully" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating contact for partner {PartnerId}", contactDetails.PartnerID);
                return StatusCode(500, new ApiResponse { Success = false, Message = "An error occurred while creating the contact" });
            }
        }

        // POST: api/partners/training
        [HttpPost("CreateTraining")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ApiResponse>> CreateTraining([FromBody] PartnerTrainingModel trainingDetails)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new ApiResponse { Success = false, Message = "Invalid model state" });
                }

                var partnerTraining = new PartnerTraining
                {
                    PartnerId = trainingDetails.PartnerID,
                    TrainingName = trainingDetails.TrainingName,
                    TrainingType = trainingDetails.TrainingType,
                    CompletionDate = trainingDetails.CompletionDate,
                    CertIssuedTo = trainingDetails.CertIssuedTo,
                    CertificateUploaded = trainingDetails.CertificateUploaded
                };

                _context1.PartnerTrainings.Add(partnerTraining);
                await _context1.SaveChangesAsync();

                return CreatedAtAction(nameof(GetTrainingDetails), new { id = partnerTraining.TrainingId },
                    new ApiResponse { Success = true, Id = partnerTraining.PartnerId, Message = "Training created successfully" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating training for partner {PartnerId}", trainingDetails.PartnerID);
                return StatusCode(500, new ApiResponse { Success = false, Message = "An error occurred while creating the training" });
            }
        }

        // POST: api/partners/opportunity
        [HttpPost("CreateOpportunity")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ApiResponse>> CreateOpportunity([FromBody] PartnerOpportunityModel opportunityDetails)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new ApiResponse { Success = false, Message = "Invalid model state" });
                }

                var partnerOpportunity = new PartnerOpportunity
                {
                    PartnerId = opportunityDetails.PartnerID,
                    OpportunityName = opportunityDetails.OpportunityName,
                    OpportunityType = opportunityDetails.OpportunityType,
                    ProductName = opportunityDetails.ProductName,
                    SerialNumber = opportunityDetails.SerialNumber,
                    FortiCareId = opportunityDetails.FortiCareID,
                    CoTermQuoteId = opportunityDetails.CoTermQuoteID,
                    TradeUpId = opportunityDetails.TradeUpID,
                    IsSdwanopportunity = opportunityDetails.IsSDWANOpportunity,
                    IsOperationalTechnologyOpportunity = opportunityDetails.IsOperationalTechnologyOpportunity,
                    EstimatedValue = opportunityDetails.EstimatedValue,
                    StatusId = opportunityDetails.StatusID,
                    DealRegOot = opportunityDetails.DealRegOOT,
                    IsRenewalOver9999 = opportunityDetails.IsRenewalOver9999,
                    FedDeal = opportunityDetails.FedDeal,
                    TradeIn = opportunityDetails.TradeIn,
                    DealType = opportunityDetails.DealType,
                    CreatedDate = DateTime.UtcNow,
                    CloseDate = DateTime.UtcNow,
                    Description = opportunityDetails.Description,
                    Notes = opportunityDetails.Notes,
                    ChangedBy = opportunityDetails.ChangedBy
                };

                _context1.PartnerOpportunities.Add(partnerOpportunity);
                await _context1.SaveChangesAsync();

                return CreatedAtAction(nameof(GetOpportunityDetails), new { id = partnerOpportunity.OpportunityId },
                    new ApiResponse { Success = true, Id = partnerOpportunity.PartnerId, Message = "Opportunity created successfully" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating opportunity for partner {PartnerId}", opportunityDetails.PartnerID);
                return StatusCode(500, new ApiResponse { Success = false, Message = "An error occurred while creating the opportunity" });
            }
        }

        // POST: api/partners/login
        [HttpPost("CreateLogin")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ApiResponse>> CreateLogin([FromBody] PartnerLoginModel loginDetails)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new ApiResponse { Success = false, Message = "Invalid model state" });
                }

                // Consider encrypting the password before storing
                var encryptedPassword = EncryptPassword(loginDetails.Password);

                var partnerLogin = new PartnerLogin
                {
                    PartnerId = loginDetails.PartnerID,
                    Username = loginDetails.Username,
                    Password = encryptedPassword,
                    LoginUrl = loginDetails.LoginURL
                };

                _context1.PartnerLogins.Add(partnerLogin);
                await _context1.SaveChangesAsync();

                return CreatedAtAction(nameof(GetLoginDetails), new { id = partnerLogin.LoginId },
                    new ApiResponse { Success = true, Id = partnerLogin.PartnerId, Message = "Login created successfully" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating login for partner {PartnerId}", loginDetails.PartnerID);
                return StatusCode(500, new ApiResponse { Success = false, Message = "An error occurred while creating the login" });
            }
        }

        private string EncryptPassword(string password)
        {
            // Implement proper password encryption/hashing here
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                var bytes = System.Text.Encoding.UTF8.GetBytes(password);
                var hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        // GET: api/trainings
        [HttpGet("GetTrainings")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<PartnerTrainingDto>>> GetTrainings()
        {
            try
            {
                var trainings = await _context1.PartnerTrainings
                    .Include(t => t.Partner)
                    .OrderByDescending(x => x.TrainingId)
                    .Select(t => new PartnerTrainingDto
                    {
                        TrainingID = t.TrainingId,
                        PartnerID = t.PartnerId,
                        PartnerName = t.Partner.Name,
                        TrainingName = t.TrainingName,
                        TrainingType = t.TrainingType,
                        CompletionDate = Convert.ToDateTime(t.CompletionDate),
                        CertIssuedTo = t.CertIssuedTo,
                        CertificateUploaded = t.CertificateUploaded
                    })
                    .ToListAsync();

                return Ok(trainings);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving trainings");
                return StatusCode(500, new ApiResponse { Success = false, Message = "An error occurred while retrieving trainings" });
            }
        }

        // GET: api/trainings/partners
        [HttpGet("trainings/partners")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<PartnerDropdownDto>>> GetPartnersForDropdown()
        {
            try
            {
                var partners = await _context1.Partners
                    .OrderBy(p => p.Name)
                    .Select(p => new PartnerDropdownDto
                    {
                        PartnerID = p.PartnerId,
                        Name = p.Name
                    })
                    .ToListAsync();

                return Ok(partners);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving partners for dropdown");
                return StatusCode(500, new ApiResponse { Success = false, Message = "An error occurred while retrieving partners" });
            }
        }

        // GET: api/trainings/{id}
        [HttpGet("GetTraining/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PartnerTrainingDto>> GetTraining(int id)
        {
            try
            {
                var training = await _context1.PartnerTrainings
                    .Include(t => t.Partner)
                    .FirstOrDefaultAsync(t => t.TrainingId == id);

                if (training == null)
                {
                    return NotFound(new ApiResponse { Success = false, Message = "Training not found" });
                }

                var trainingDto = new PartnerTrainingDto
                {
                    TrainingID = training.TrainingId,
                    PartnerID = training.PartnerId,
                    PartnerName = training.Partner.Name,
                    TrainingName = training.TrainingName,
                    TrainingType = training.TrainingType,
                    CompletionDate = Convert.ToDateTime(training.CompletionDate),
                    CertIssuedTo = training.CertIssuedTo,
                    CertificateUploaded = training.CertificateUploaded
                };

                return Ok(trainingDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving training {TrainingId}", id);
                return StatusCode(500, new ApiResponse { Success = false, Message = "An error occurred while retrieving the training" });
            }
        }
    }
}