// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// <auto-generated />

using System;
using System.Net;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using Getitdone.Service.Models;
using Getitdone.Service;

namespace Getitdone.Service.Controllers
{
    [ApiController]
    public abstract partial class ProjectOpsOperationsControllerBase : ControllerBase
    {

        internal abstract IProjectOpsOperations ProjectOpsOperationsImpl { get; }


        [HttpGet]
        [Route("/projects/{project_id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(Project))]
        public virtual async Task<IActionResult> GetProject(string projectId)
        {
            var result = await ProjectOpsOperationsImpl.GetProjectAsync(projectId);
            return Ok(result);
        }


        [HttpPost]
        [Route("/projects/{project_id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(Project))]
        public virtual async Task<IActionResult> UpdateProject(string projectId, UpdateProjectRequest body)
        {
            var result = await ProjectOpsOperationsImpl.UpdateProjectAsync(projectId, body);
            return Ok(result);
        }


        [HttpDelete]
        [Route("/projects/{project_id}")]
        [ProducesResponseType((int)HttpStatusCode.NoContent, Type = typeof(void))]
        public virtual async Task<IActionResult> DeleteProject(string projectId)
        {
            await ProjectOpsOperationsImpl.DeleteProjectAsync(projectId);
            return Ok();
        }


        [HttpGet]
        [Route("/projects/{project_id}/collaborators")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(Collaborator[]))]
        public virtual async Task<IActionResult> GetCollaborators(string projectId)
        {
            var result = await ProjectOpsOperationsImpl.GetCollaboratorsAsync(projectId);
            return Ok(result);
        }

    }
}
