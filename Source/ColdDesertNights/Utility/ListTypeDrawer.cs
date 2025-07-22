using System;
using System.Collections.Generic;
using System.Linq;
using HugsLib.Settings;
using UnityEngine;
using Verse;

namespace ColdDesertNights.Utility;

public class ListTypeDrawer<T>(
    SettingHandle<T> handle,
    IEnumerable<T> options,
    Func<T, string> getLabelFunc,
    bool includeDefaultOption)
{
    private readonly List<T> options = [..options];
    private bool hasChanged;

    public bool Draw(Rect controlRect)
    {
        // Get our current label and try to draw it to the screen:
        var label = getLabel(handle.Value);
        if (!Widgets.ButtonText(controlRect, label))
        {
            return true;
        }

        // Iterate our options:
        var opts = options
            .Select(t => new FloatMenuOption(getLabel(t), () =>
            {
                handle.Value = t;
                hasChanged = true;
            })).ToList();

        Find.WindowStack.Add(new FloatMenu(opts));

        if (!hasChanged)
        {
            return false;
        }

        hasChanged = false;
        return true;
    }

    /// <summary>
    ///     Gets the label for the given instance
    /// </summary>
    /// <param name="opt">The option to get the label for</param>
    /// <returns>The text</returns>
    private string getLabel(T opt)
    {
        return opt == null || includeDefaultOption && EqualityComparer<T>.Default.Equals(opt, default)
            ? "ColdDesertNights_SelectList_Default".Translate()
            : (TaggedString)GenText.ToTitleCaseSmart(getLabelFunc(opt));
    }
}