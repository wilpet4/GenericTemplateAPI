﻿using GenericTemplateAPI.API.Entities.Base;
using GenericTemplateAPI.API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericTemplateAPI.API.Controllers.Base
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class ApiController<TEntity, TKey> : ControllerBase where TEntity : Entity
    {

        protected readonly Repository<TEntity, TKey> _repository;

        public ApiController(Repository<TEntity, TKey> repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}")]
        public virtual async Task<ActionResult<TEntity>> GetEntity(TKey id)
        {
            try
            {
                var entity = await _repository.GetEntity(id);

                if (entity == null) { return NotFound(); }

                return Ok(entity);
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }

        [HttpGet]
        public virtual async Task<ActionResult<IEnumerable<TEntity>>> GetEntities()
        {
            try
            {
                var entities = await _repository.GetEntities();

                if (entities == null) { return NotFound(); }

                return Ok(entities);
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }

        [HttpPost]
        public virtual async Task<IActionResult> CreateEntity(TEntity entity)
        {
            try
            {
                if (entity == null) { return NotFound(); }

                await _repository.CreateEntity(entity);

                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> UpdateEntity(TKey id, TEntity entity)
        {
            try
            {
                if (entity == null) { return NotFound(); }

                await _repository.UpdateEntity(entity);

                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> DeleteEntity(TKey id)
        {
            try
            {
                var entity = await _repository.GetEntity(id);

                if (entity == null) { return NotFound(); }

                await _repository.DeleteEntity(id);

                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }
    }
}
