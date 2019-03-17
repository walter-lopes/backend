﻿using LightBDD.Framework;
using LightBDD.Framework.Scenarios;
using LightBDD.XUnit2;
using ShareBook.Tests.BDD.Configurations;

[assembly: ConfiguredLightBddScope]
namespace ShareBook.Tests.BDD.Features
{
	[Label("REGISTER-USER")]
	[FeatureDescription(
        @"New user wants to join in sharebook plataform")]
	public partial class RegisterUserFeature
	{
		[Label("Registration with all data correct")]
		[Scenario]
		public void Template_basic_scenario()
		{
			Runner.RunScenario(
                Given_new_user_want_to_join_with_this_datas,
                When_the_new_user_registers,
                Then_will_receive_a_success_message);
		}
	}
}