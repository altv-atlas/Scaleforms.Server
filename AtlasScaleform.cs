using System.Text.Json;
using AltV.Atlas.Scaleforms.Shared;
using AltV.Atlas.Scaleforms.Shared.Models;
using AltV.Net.Elements.Entities;
namespace AltV.Atlas.Scaleforms.Server;

/// <summary>
/// The atlas class that provides useful scaleform methods
/// </summary>
public static class AtlasScaleform
{
    /// <summary>
    /// Draws a scaleform with the given industrial buttons
    /// </summary>
    /// <param name="player">The player to draw it for</param>
    /// <param name="buttons">The buttons to draw</param>
    public static void DrawIndustrialMenuScaleform( this IPlayer player, IList<IndustrialButton> buttons )
    {
        var industrialButtons = JsonSerializer.Serialize( buttons );

        player.Emit( ScaleformConstants.DrawIndustrialMenuEventName, industrialButtons );
    }

    /// <summary>
    /// Hides the industrial menu scaleform
    /// </summary>
    /// <param name="player">The player to hide it for</param>
    public static void HideIndustrialMenuScaleform( this IPlayer player ) => player.Emit( ScaleformConstants.HideIndustrialMenuEventName );
}