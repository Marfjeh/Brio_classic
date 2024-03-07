using Dalamud.Interface.Windowing;
using ImGuiNET;
using System.Diagnostics;
using System.Numerics;
using System.Reflection;

namespace Brio.UI.Windows;

public class InfoWindow : Window
{
    private static Vector2 ButtonSize = new Vector2(150, 25);

    public InfoWindow() : base($"{Brio.PluginName} Information", ImGuiWindowFlags.NoScrollbar | ImGuiWindowFlags.AlwaysAutoResize)
    {
        Size = new Vector2(580, -1);
    }

    public override void Draw()
    {
        ImGui.BeginGroup();

        ImGui.Text($"Welcome to Brio Classic v{Brio.PluginVersion}!");

        ImGui.Spacing();

        //ImGui.Text("Brio is a small set of utilities from Asgard and Minmoose.");
        //ImGui.Text("It is designed to enhance the experience of using GPose.");
        //ImGui.Text("It is not a posing tool (like Anamnesis or Ktisis).");

        //ImGui.Spacing();

        ImGui.Text("This plugin is a fork of the older UI from Brio.");
        ImGui.Text("And it is a UNSUPPORTED Version.");
        ImGui.Text("Please do not report any issues to Brio itself!");
        ImGui.Text("instead, use the fork repo for issues.");

        ImGui.Spacing();

        ImGui.PushStyleColor(ImGuiCol.Button, new Vector4(0, 100, 0, 255) / 255);
        if(ImGui.Button("Get Started", ButtonSize))
        {
            IsOpen = false;
            UIService.Instance.MainWindow.IsOpen = true;
        }
        ImGui.PopStyleColor();

        ImGui.EndGroup();

        ImGui.SameLine(ImGui.GetItemRectSize().X + 50);

        ImGui.BeginGroup();

        ImGui.PushStyleColor(ImGuiCol.Button, new Vector4(255, 0, 0, 255) / 255);
        if(ImGui.Button("(New) Report Issue", ButtonSize))
            Process.Start(new ProcessStartInfo { FileName = "https://github.com/Marfjeh/Brio_classic/issues", UseShellExecute = true });
        ImGui.PopStyleColor();

        ImGui.PushStyleColor(ImGuiCol.Button, new Vector4(110, 84, 148, 255) / 255);
        if(ImGui.Button("(New) GitHub Repository", ButtonSize))
            Process.Start(new ProcessStartInfo { FileName = "https://github.com/Marfjeh/Brio_classic", UseShellExecute = true });
        ImGui.PopStyleColor();

        ImGui.EndGroup();
    }
}
