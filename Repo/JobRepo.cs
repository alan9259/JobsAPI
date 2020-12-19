using JobsAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsAPI.Repo
{
    
    public interface IJobRepo
    {
        Task<IEnumerable<Job>> GetJobs(JobFilter filter);
        Task<IEnumerable<Job>> GetJobsByTitle(string title);
        Task<Job> GetJob(int id);
        Task<Job> CreateJob(Job job);
        Task UpdateJob(Job job);
        Task DeleteJob(int id);
    }

    public class JobRepo : IJobRepo
    {
        private readonly JobDbContext _jobDbContext;
        public JobRepo(JobDbContext jobDbContext) {
            _jobDbContext = jobDbContext;
        }

        public async Task<IEnumerable<Job>> GetJobs(JobFilter filter)
        {
            var query =  _jobDbContext.Jobs
                .Where(j => j.IsActive == filter.IsActive);

            if (filter.PostedOn != default)
            {
                query.Where(j => j.PostedOn > filter.PostedOn);
            }

            if (!string.IsNullOrWhiteSpace(filter.Title))
            {
                query.Where(j => j.Title.Contains(filter.Title));
            }

            var jobs = await query.ToListAsync();

            return jobs;
        }

        public async Task<IEnumerable<Job>> GetJobsByTitle(string title)
        {
            var jobs = await _jobDbContext.Jobs
                .Where(j => j.Title.Contains(title) && j.IsActive == true)
                .ToListAsync();

            return jobs;
        }

        public async Task<Job> GetJob(int id)
        {
            var job = await _jobDbContext.Jobs.FindAsync(id);

            return job;
        }

        public async Task<Job> CreateJob(Job job)
        {
            _jobDbContext.Jobs.Add(job);
            
            await _jobDbContext.SaveChangesAsync();

            return job;
        }

        public async Task UpdateJob(Job job)
        {
            _jobDbContext.Entry(job).State = EntityState.Modified;
            await _jobDbContext.SaveChangesAsync();
        }

        public async Task DeleteJob(int id)
        {
            var job = await GetJob(id);

            _jobDbContext.Remove(job);
            await _jobDbContext.SaveChangesAsync();
        }
    }
}
