using Lume.Domain.Repositories;

namespace Lume.Application.Prenotations;

/// <summary>
/// Service for managing prenotations
/// </summary>
/// <param name="prenotationRepository">Operations</param>
internal class PrenotationService(IPrenotationRepository prenotationRepository) : IPrenotationService
{
    
}