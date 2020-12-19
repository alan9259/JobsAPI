using JobsAPI.Model;
using JobsAPI.Repo;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsAPI.Service
{
    public interface IJobService
    {
        Task<IEnumerable<Job>> GetJobs(JobFilter filter);
        Task<Job> GetJob(int id);
        Task<Job> CreateJob(Job job);
        Task UpdateJob(int id, Job job);
        Task DeleteJob(int id);
    }
    public class JobService : IJobService
    {
        private readonly IJobRepo _jobRepo;

        public JobService(IJobRepo jobRepo)
        {
            _jobRepo = jobRepo;
        }

        public async Task<IEnumerable<Job>> GetJobs(JobFilter filter)
        {

            var jobs = await _jobRepo.GetJobs(filter);

            return jobs;
        }

        public async Task<Job> GetJob(int id)
        {
            var job = await _jobRepo.GetJob(id);
            return job;
        }

        public async Task<Job> CreateJob(Job job)
        {
            var res = await _jobRepo.CreateJob(job);
            return res;
        }

        public async Task UpdateJob(int id, Job job)
        {
            job.ID = id;
            await _jobRepo.UpdateJob(job);
        }

        public async Task DeleteJob(int id)
        {
            await _jobRepo.DeleteJob(id);
        }
    }
}
