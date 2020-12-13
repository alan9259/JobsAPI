using JobsAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsAPI.Repo
{
    public interface IJobRepo
    {
        IEnumerable<Job> GetJobs();
    }

    public class JobRepo : IJobRepo
    {

        public JobRepo() { }

        public IEnumerable<Job> GetJobs()
        {
            var jobs = new List<Job>()
            {
                {new Job { ID = 1, IsActive = true, Title = "Fu Er Dai", Location="Watchtower, Washington", Company ="QUORDATE",  Email="frankhorton@quordate.com", Industry="Rich", JobDesc="Veniam laborum veniam commodo veniam nisi commodo. Culpa elit qui deserunt adipisicing ad dolor proident laboris adipisicing tempor eu. Elit do non occaecat exercitation ullamco deserunt. Aliquip labore consectetur elit id. Voluptate cupidatat dolore eiusmod labore eu. Consectetur ipsum mollit tempor eiusmod id ipsum sit.", Picture="https://i.picsum.photos/id/703/300/150.jpg?hmac=u4EJJhnL7eJiV1Ub0wJ5El9hPvAeZvfIIJuKvVFtNus", PostedOn=DateTime.Parse("2020-12-11T04:48:37") } },
                {new Job { ID = 2, IsActive = true, Title = "Project Engineer", Location="Concho, Oregon", Company ="TROPOLIS",  Email="frankhorton@tropolis.com", Industry="Engineering", JobDesc="Pariatur enim labore dolore aliqua voluptate non eiusmod dolor quis quis. Fugiat labore enim laborum labore aliqua occaecat minim ut. Reprehenderit est reprehenderit consectetur do. Nisi qui sint quis culpa velit ea. Commodo veniam sit laborum ipsum in. Cupidatat ullamco voluptate elit et exercitation amet sunt et exercitation voluptate in in nisi velit.", Picture="https://i.picsum.photos/id/621/300/150.jpg?hmac=_1HUfgf2hdXT2zc6zC1O3MsCTnCa9B_uZsBbLu7LXis", PostedOn=DateTime.Parse("2020-12-11T05:43:37") } },
                {new Job { ID = 3, IsActive = true, Title = "Corporate Advisory", Location="Cliff, Federated States Of Micronesia", Company ="ACIUM",  Email="frankhorton@acium.com", Industry="Finance", JobDesc="Proident sit nulla id Lorem laboris qui irure occaecat. Labore eu minim fugiat nisi ea sunt velit pariatur officia consectetur ea proident veniam tempor. Elit do cupidatat dolor elit.", Picture="https://i.picsum.photos/id/1078/300/150.jpg?hmac=AK5BwU38WcegZssja9EiCB9xd7tIROT5JbYCPZvCwsY", PostedOn=DateTime.Parse("2020-10-07T08:11:37") } },
                {new Job { ID = 4, IsActive = false, Title = "Senior Software Engineer", Location="Websterville, Virgin Islands", Company ="ANDERSHUN",  Email="frankhorton@andershun.com", Industry="IT", JobDesc="Nostrud in fugiat consequat et voluptate pariatur aliquip in quis velit eiusmod. Do in commodo aliquip id exercitation veniam sunt. Nulla dolore ipsum elit veniam ut et et veniam aliqua. Ea Lorem veniam proident aliqua elit elit eiusmod sunt in elit nisi sint.", Picture="https://i.picsum.photos/id/177/300/150.jpg?hmac=nPEKiWjgBnDbL-NSZ-1JyRiF5I18o4p-JkO-HTlkhTE", PostedOn=DateTime.Parse("2020-11-12T02:44:00") } },
                {new Job { ID = 5, IsActive = false, Title = "Marketing Executive", Location="Clarence, Indiana", Company ="QUARMONY",  Email="frankhorton@quarmony.com", Industry="Marketing", JobDesc="Sunt exercitation duis nostrud culpa Lorem adipisicing deserunt fugiat pariatur ipsum laboris consequat quis velit. Ea commodo anim Lorem laborum cupidatat deserunt aliqua. Adipisicing velit nostrud ipsum proident id consequat aliquip nisi eu nostrud dolor. Culpa nulla sunt aliquip do voluptate ex elit elit commodo nostrud occaecat proident amet. Esse commodo consectetur est labore esse duis sunt labore nulla culpa cillum culpa ex sint. Enim fugiat proident laboris magna laboris est excepteur labore ad non labore ut.", Picture="https://i.picsum.photos/id/296/300/150.jpg?hmac=MfZDQr0akcTtCtMjO0HsOGdgOXM1GDPJFfstK2nphYY", PostedOn=DateTime.Parse("2020-05-21T05:47:12") } },
                {new Job { ID = 6, IsActive = true, Title = "Test Analyst", Location="Sattley, Pennsylvania", Company ="UNQ",  Email="frankhorton@unq.com", Industry="IT", JobDesc="Officia incididunt ad id laborum aliqua laboris labore amet irure duis et ex consequat elit. Dolore ut consectetur eiusmod deserunt laborum non consectetur magna est incididunt nisi eu magna eiusmod. Do ad dolore adipisicing consectetur incididunt veniam sit cillum. Ullamco exercitation Lorem eiusmod esse minim Lorem veniam aliquip culpa.", Picture="https://i.picsum.photos/id/764/300/150.jpg?hmac=E9CZODHlJdH46z1XK3r5W4FI1XtFUI6bGLmp8Nu060Q", PostedOn=DateTime.Parse("2020-04-23T04:19:40") } },
                {new Job { ID = 7, IsActive = false, Title = "Teacher Aide", Location="Hoagland, Oklahoma", Company ="CAXT",  Email="frankhorton@caxt.com", Industry="Education", JobDesc="Ea nostrud reprehenderit dolore magna duis Lorem qui deserunt ipsum nisi nulla voluptate non. Sunt id reprehenderit nulla officia consequat aute incididunt ut excepteur occaecat excepteur incididunt. Voluptate non nostrud enim proident incididunt commodo culpa enim incididunt ut est sint labore magna. Ipsum aliqua consectetur nostrud laborum minim velit.", Picture="https://i.picsum.photos/id/915/300/150.jpg?hmac=gHfv_JAFqDL7lQRpAkYZBBwHkirJDaTJ1pB4e0wBrsw", PostedOn=DateTime.Parse("2020-04-24T02:43:09") } },
            };

            return jobs;
        }
    }
}
