using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;
using Color = System.Drawing.Color;


namespace ElRengar
{
    public class Drawings
    {
        public static void Drawing_OnDraw(EventArgs args)
        {

            var drawOff = ElRengarMenu._menu.Item("ElRengar.Draw.off").GetValue<bool>();
            var drawW = ElRengarMenu._menu.Item("ElRengar.Draw.W").GetValue<Circle>();
            var drawE = ElRengarMenu._menu.Item("ElRengar.Draw.E").GetValue<Circle>();
            var drawR = ElRengarMenu._menu.Item("ElRengar.Draw.R").GetValue<Circle>();

            if (drawOff)
                return;

            if (drawW.Active)
                if (Rengar.spells[Spells.W].Level > 0)
                    Render.Circle.DrawCircle(ObjectManager.Player.Position, Rengar.spells[Spells.W].Range, Rengar.spells[Spells.W].IsReady() ? Color.Green : Color.Red);

            if (drawE.Active)
                if (Rengar.spells[Spells.E].Level > 0)
                    Render.Circle.DrawCircle(ObjectManager.Player.Position, Rengar.spells[Spells.E].Range, Rengar.spells[Spells.E].IsReady() ? Color.Green : Color.Red);

            if (drawR.Active)
                if (Rengar.spells[Spells.R].Level > 0)
                    Render.Circle.DrawCircle(ObjectManager.Player.Position, Rengar.spells[Spells.R].Range, Rengar.spells[Spells.R].IsReady() ? Color.Green : Color.Red);
        }
    }
}