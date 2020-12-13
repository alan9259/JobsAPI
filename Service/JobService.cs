using JobsAPI.Model;
using JobsAPI.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsAPI.Service
{
    public interface IJobService
    {
        Task<IEnumerable<Job>> GetJobs();
    }
    public class JobService : IJobService
    {
        private readonly IJobRepo _jobRepo;

        public JobService(IJobRepo jobRepo)
        {
            _jobRepo = jobRepo;
        }

        public async Task<IEnumerable<Job>> GetJobs()
        {

            var jobs = await Task.Run(() => _jobRepo.GetJobs().ToList());

            return jobs;
        }

    }
}
