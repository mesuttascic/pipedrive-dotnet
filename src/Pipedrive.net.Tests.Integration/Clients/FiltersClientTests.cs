using System.Threading.Tasks;
using Xunit;

namespace Pipedrive.Tests.Integration.Clients
{
    public class FiltersClientTests
    {
        public class TheGetAllMethod
        {
            [IntegrationTest]
            public async Task CanRetrievePipelines()
            {
                var pipedrive = Helper.GetAuthenticatedClient();

                var filters = pipedrive.Filter.GetAll().Result;

                Assert.True(filters.Count >= 1);
                Assert.True(filters[0].Active);
            }
        }

        public class TheGetMethod
        {
            [IntegrationTest]
            public async Task CanRetrievePipelines()
            {
                var pipedrive = Helper.GetAuthenticatedClient();

                var filter = pipedrive.Filter.Get(21).Result;

                Assert.True(filter.Active);
            }
        }

        public class TheEditMethod
        {
            [IntegrationTest]
            public async Task CanEdit()
            {
                var pipedrive = Helper.GetAuthenticatedClient();
                var fixture = pipedrive.Pipeline;

                var newPipeline = new NewPipeline("new-name");
                var pipeline = await fixture.Create(newPipeline);

                var editPipeline = pipeline.ToUpdate();
                editPipeline.Name = "updated-name";
                editPipeline.Active = true;

                var updatedPipeline = await fixture.Edit(pipeline.Id, editPipeline);

                Assert.Equal("updated-name", updatedPipeline.Name);
                Assert.True(updatedPipeline.Active);

                // Cleanup
                await fixture.Delete(updatedPipeline.Id);
            }
        }

        //public class TheCreateMethod
        //{
        //    [IntegrationTest]
        //    public async Task CanCreate()
        //    {
        //        var pipedrive = Helper.GetAuthenticatedClient();
        //        var fixture = pipedrive.Pipeline;

        //        var newPipeline = new NewPipeline("name");
        //        newPipeline.Active = true;

        //        var pipeline = await fixture.Create(newPipeline);
        //        Assert.NotNull(pipeline);

        //        // Cleanup
        //        await fixture.Delete(pipeline.Id);
        //    }
        //}

        //public class TheDeleteMethod
        //{
        //    [IntegrationTest]
        //    public async Task CanDelete()
        //    {
        //        var pipedrive = Helper.GetAuthenticatedClient();
        //        var fixture = pipedrive.Pipeline;

        //        var newPipeline = new NewPipeline("new-name");
        //        newPipeline.Active = true;
        //        var pipeline = await fixture.Create(newPipeline);

        //        var createdPipeline = await fixture.Get(pipeline.Id);

        //        Assert.NotNull(createdPipeline);

        //        await fixture.Delete(createdPipeline.Id);

        //        var deletedPipeline = await fixture.Get(pipeline.Id);

        //        Assert.False(deletedPipeline.Active);
        //    }
        //}
    }
}
