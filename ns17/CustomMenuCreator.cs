using ns16;
using ns18;
using ns19;
using ns20;
using ns21;
using System;

namespace ns17
{
	public class CustomMenuCreator : QbEditor
	{
		private zzPakNode2 class318_0;

		private bool bool_0;

		private bool bool_1;

		public CustomMenuCreator(zzPakNode2 class318_1, bool bool_2)
		{
			this.class318_0 = class318_1;
			this.bool_1 = bool_2;
		}

		public override void vmethod_0()
		{
			Console.WriteLine("-=- " + this.ToString() + " -=-");
			if (!this.bool_0)
			{
				this.bool_0 = this.class318_0.method_6("scripts\\guitar\\custom_menu\\guitar_custom_menu.qb");
			}
			if (!this.bool_0)
			{
				Console.WriteLine("Creating Custom Menu.");
				this.class318_0.method_0("scripts\\guitar\\custom_menu\\guitar_custom_menu.qb", zzQbScriptZipperClass.smethod_3("guitar_custom_menu"));
				this.class318_0.method_0("scripts\\guitar\\custom_menu\\guitar_custom_gem_scale.qb", zzQbScriptZipperClass.smethod_3("guitar_custom_gem_scale"));
				this.class318_0.method_0("scripts\\guitar\\custom_menu\\guitar_custom_menu_credits.qb", zzQbScriptZipperClass.smethod_3("guitar_custom_menu_credits"));
				this.class318_0.method_0("scripts\\guitar\\custom_menu\\guitar_custom_menu_cutoff_viewer.qb", zzQbScriptZipperClass.smethod_3("guitar_custom_menu_cutoff_viewer"));
				this.class318_0.method_0("scripts\\guitar\\custom_menu\\guitar_custom_menu_gfx_options.qb", zzQbScriptZipperClass.smethod_3("guitar_custom_menu_gfx_options"));
				this.class318_0.method_0("scripts\\guitar\\custom_menu\\guitar_custom_menu_setlist_switcher.qb", zzQbScriptZipperClass.smethod_3("guitar_custom_menu_setlist_switcher"));
				zzGenericNode1 @class = this.class318_0.zzGetNode1(this.bool_1 ? "scripts\\guitar\\menu\\menu_main.qb" : "scripts\\guitar\\guitar_menu.qb");
				zzQbScriptZipperClass.smethod_1(@class.method_5<ScriptRootNode>(new ScriptRootNode("create_main_menu")));
				@class = this.class318_0.zzGetNode1("scripts\\guitar\\guitar_progression.qb");
				zzQbScriptZipperClass.smethod_1(@class.method_5<ScriptRootNode>(new ScriptRootNode("get_progression_globals")));
				@class = this.class318_0.zzGetNode1("scripts\\guitar\\guitar_gems.qb");
				zzQbScriptZipperClass.smethod_1(@class.method_5<ScriptRootNode>(new ScriptRootNode("load_venue")));
				zzQbScriptZipperClass.smethod_1(@class.method_5<ScriptRootNode>(new ScriptRootNode("start_gem_scroller")));
				zzQbScriptZipperClass.smethod_1(@class.method_5<ScriptRootNode>(new ScriptRootNode("kill_gem_scroller")));
				@class = this.class318_0.zzGetNode1("scripts\\guitar\\guitar_events.qb");
				zzQbScriptZipperClass.smethod_1(@class.method_5<ScriptRootNode>(new ScriptRootNode("guitarevent_songwon_spawned")));
				@class = this.class318_0.zzGetNode1("scripts\\game\\net\\guitar_net.qb");
				zzQbScriptZipperClass.smethod_1(@class.method_5<ScriptRootNode>(new ScriptRootNode("net_write_single_player_stats")));
				@class = this.class318_0.zzGetNode1("scripts\\guitar\\guitar_globaltags.qb");
				zzQbScriptZipperClass.smethod_1(@class.method_5<ScriptRootNode>(new ScriptRootNode("setup_globaltags")));
				zzQbScriptZipperClass.smethod_1(@class.method_5<ScriptRootNode>(new ScriptRootNode("setup_songtags")));
				zzQbScriptZipperClass.smethod_1(@class.method_5<ScriptRootNode>(new ScriptRootNode("push_bandtags")));
				@class = this.class318_0.zzGetNode1("scripts\\guitar\\menu\\menu_credits.qb");
				zzQbScriptZipperClass.smethod_1(@class.method_5<ScriptRootNode>(new ScriptRootNode("scrolling_list_add_item")));
				if (!this.bool_1)
				{
					zzQbScriptZipperClass.smethod_1(@class.method_5<ScriptRootNode>(new ScriptRootNode("start_team_photos")));
				}
				if (this.bool_1)
				{
					@class = this.class318_0.zzGetNode1("scripts\\guitar\\custom_menu\\guitar_custom_menu_cutoff_viewer.qb");
					zzQbScriptZipperClass.smethod_1(@class.method_5<ScriptRootNode>(new ScriptRootNode("custom_menu_cutoff_viewer_create_paper")));
					zzQbScriptZipperClass.smethod_1(@class.method_5<ScriptRootNode>(new ScriptRootNode("custom_menu_cutoff_viewer_create_poster")));
				}
				@class = this.class318_0.zzGetNode1("scripts\\guitar\\menu\\main_menu_flow.qb");
				StructureHeaderNode class2 = new StructureHeaderNode();
				class2.method_3(new TagStructureNode("action", "select_custom_menu"));
				class2.method_3(new TagStructureNode("flow_state", "custom_menu_fs"));
				class2.method_3(new TagStructureNode(0, "transition_right"));
				@class.method_5<StructurePointerRootNode>(new StructurePointerRootNode("main_menu_fs")).method_5<ArrayPointerNode>(new ArrayPointerNode("actions")).method_8().method_3(class2);
			}
		}

		public override string ToString()
		{
			return "Create Custom Menu";
		}

		public override bool Equals(QbEditor other)
		{
			return other is CustomMenuCreator;
		}
	}
}
