//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Articy.Unity;
using Articy.Unity.Interfaces;
using System;
using System.Collections;
using UnityEngine;


namespace Articy.Project_Of_Death.GlobalVariables
{
    
    
    [Serializable()]
    [CreateAssetMenu(fileName="ArticyGlobalVariables", menuName="Create GlobalVariables", order=620)]
    public class ArticyGlobalVariables : BaseGlobalVariables
    {
        
        [SerializeField()]
        [HideInInspector()]
        private intro mIntro = new intro();
        
        [SerializeField()]
        [HideInInspector()]
        private game mGame = new game();
        
        [SerializeField()]
        [HideInInspector()]
        private profile mProfile = new profile();
        
        [SerializeField()]
        [HideInInspector()]
        private day mDay = new day();
        
        [SerializeField()]
        [HideInInspector()]
        private rep mRep = new rep();
        
        [SerializeField()]
        [HideInInspector()]
        private shop mShop = new shop();
        
        [SerializeField()]
        [HideInInspector()]
        private mirror mMirror = new mirror();
        
        [SerializeField()]
        [HideInInspector()]
        private inventory mInventory = new inventory();
        
        [SerializeField()]
        [HideInInspector()]
        private book mBook = new book();
        
        #region Initialize static VariableName set
        static ArticyGlobalVariables()
        {
            variableNames.Add("intro.done");
            variableNames.Add("intro.asked_for_salary");
            variableNames.Add("game.finished");
            variableNames.Add("game.salary_on");
            variableNames.Add("game.warning_marked_zero_first_done");
            variableNames.Add("game.warning_marked_zero_second_done");
            variableNames.Add("game.warning_marked_zero_third_done");
            variableNames.Add("game.warning_marked_all_first_done");
            variableNames.Add("game.warning_marked_all_second_done");
            variableNames.Add("game.warning_marked_all_third_done");
            variableNames.Add("game.game_over_fired");
            variableNames.Add("game.game_over_not_fired");
            variableNames.Add("game.backpay");
            variableNames.Add("game.toy_given_to_cat");
            variableNames.Add("game.cat_extremely_annoyed");
            variableNames.Add("game.subplot_activated");
            variableNames.Add("game.subplot_second_step_activated");
            variableNames.Add("game.toy_odd_behaviour");
            variableNames.Add("game.work_complaint_counter");
            variableNames.Add("game.got_globe_from_fate");
            variableNames.Add("game.toy_know_alive");
            variableNames.Add("game.subplot_finale_activated");
            variableNames.Add("game.subplot_continues_from_day_18");
            variableNames.Add("game.fate_absent");
            variableNames.Add("game.backpay_amount");
            variableNames.Add("game.subplot_finale_wait_1st");
            variableNames.Add("game.subplot_finale_wait_2nd");
            variableNames.Add("game.subplot_finale_wait_3rd");
            variableNames.Add("game.subplot_finale_wait_4th");
            variableNames.Add("game.got_salary_raise");
            variableNames.Add("game.salary_bonus_pending");
            variableNames.Add("game.liked_ice_cream");
            variableNames.Add("game.suggested_myum");
            variableNames.Add("game.subplot_sat_desk");
            variableNames.Add("game.easter_egg_killed_all");
            variableNames.Add("game.easter_egg_spared_all");
            variableNames.Add("game.name_sugar_and_space");
            variableNames.Add("game.name_rainbow_and_puppies");
            variableNames.Add("game.name_blood_and_guts");
            variableNames.Add("game.name_beeps_and_boops");
            variableNames.Add("game.name_death_and_taxes");
            variableNames.Add("game.name_nothing");
            variableNames.Add("game.easter_egg_unlocked");
            variableNames.Add("profile.columba_hunter_spared");
            variableNames.Add("profile.columba_hunter_died");
            variableNames.Add("profile.alexis_wu_died");
            variableNames.Add("profile.alexis_wu_spared");
            variableNames.Add("profile.blair_presley_spared");
            variableNames.Add("profile.blair_presley_died");
            variableNames.Add("profile.dale_bailey_died");
            variableNames.Add("profile.dale_bailey_spared");
            variableNames.Add("profile.fate_spared");
            variableNames.Add("profile.evil_ecology_trigger");
            variableNames.Add("profile.evil_health_trigger");
            variableNames.Add("profile.evil_peace_trigger");
            variableNames.Add("profile.evil_prosperity_trigger");
            variableNames.Add("profile.cultist_mercury_spared");
            variableNames.Add("profile.arsonist_rufus_spared");
            variableNames.Add("profile.seismologist_aisling_died");
            variableNames.Add("profile.last_human_spared");
            variableNames.Add("profile.last_human_died");
            variableNames.Add("profile.name_caleb");
            variableNames.Add("profile.name_kathleen");
            variableNames.Add("profile.name_otto");
            variableNames.Add("profile.name_walt");
            variableNames.Add("profile.name_january");
            variableNames.Add("profile.name_zayn");
            variableNames.Add("profile.name_carrie");
            variableNames.Add("profile.name_moha");
            variableNames.Add("profile.lanzo_marking_question_trigger");
            variableNames.Add("profile.pineapple_guy_died");
            variableNames.Add("profile.pineapple_guy_spared");
            variableNames.Add("profile.langston_pope_spared");
            variableNames.Add("day.death_count");
            variableNames.Add("day.profile_count");
            variableNames.Add("day.six_done_cons_trigger");
            variableNames.Add("day.test_boolean_switch");
            variableNames.Add("day.six_eco_trigger");
            variableNames.Add("day.six_peace_trigger");
            variableNames.Add("day.six_prosperity_trigger");
            variableNames.Add("day.six_health_trigger");
            variableNames.Add("day.five_asked_about_children");
            variableNames.Add("day.five_asked_about_animals");
            variableNames.Add("day.five_asked_about_unliving");
            variableNames.Add("day.five_asked_about_points");
            variableNames.Add("day.spare_count");
            variableNames.Add("day.peace_change");
            variableNames.Add("day.ecology_change");
            variableNames.Add("day.health_change");
            variableNames.Add("day.prosperity_change");
            variableNames.Add("day.ten_grim_digression");
            variableNames.Add("day.twelve_asked_about_death");
            variableNames.Add("day.twelve_asked_about_fate");
            variableNames.Add("day.twelve_asked_about_taxes");
            variableNames.Add("day.twelve_asked_about_cattalk");
            variableNames.Add("day.sixteen_heard_book_idea");
            variableNames.Add("day.eighteen_heard_book_plan");
            variableNames.Add("day.thirteen_no_profiles");
            variableNames.Add("day.fourteen_got_extreme");
            variableNames.Add("day.fourteen_got_high");
            variableNames.Add("day.fourteen_got_low");
            variableNames.Add("day.fifteen_asked_rules");
            variableNames.Add("day.fifteen_asked_self");
            variableNames.Add("day.fifteen_asked_time");
            variableNames.Add("day.fifteen_asked_chess");
            variableNames.Add("day.fifteen_rules_and_time");
            variableNames.Add("day.nineteen_asked_history");
            variableNames.Add("day.nineteen_asked_dying");
            variableNames.Add("day.nineteen_asked_afterlife");
            variableNames.Add("day.nineteen_asked_deathdrive");
            variableNames.Add("day.nineteen_asked_language");
            variableNames.Add("day.seventeen_plan_mentioned");
            variableNames.Add("day.twenty_done_cons_trigger");
            variableNames.Add("day.current_count");
            variableNames.Add("day.one_mark_all");
            variableNames.Add("day.one_mark_none");
            variableNames.Add("day.five_asked_about_they_gender");
            variableNames.Add("day.nine_marked_all_plants");
            variableNames.Add("day.four_spared_fates_extra_profile");
            variableNames.Add("day.nine_spared_all_plants");
            variableNames.Add("day.two_mark_all");
            variableNames.Add("day.two_mark_none");
            variableNames.Add("day.three_mark_none");
            variableNames.Add("day.three_mark_all");
            variableNames.Add("day.four_mark_all");
            variableNames.Add("day.seven_marked_many_or_all");
            variableNames.Add("day.seven_marked_few_or_none");
            variableNames.Add("day.twelve_few_or_none");
            variableNames.Add("day.twelve_many_or_all");
            variableNames.Add("day.fourteen_few_or_none");
            variableNames.Add("day.fourteen_many_or_all");
            variableNames.Add("day.fifteen_few_or_none");
            variableNames.Add("day.fifteen_many_or_all");
            variableNames.Add("day.sixteen_few_or_none");
            variableNames.Add("day.sixteen_many_or_all");
            variableNames.Add("day.seventeen_few_or_none");
            variableNames.Add("day.seventeen_many_or_all");
            variableNames.Add("day.eighteen_few_or_none");
            variableNames.Add("day.eighteen_many_or_all");
            variableNames.Add("day.twoone_all");
            variableNames.Add("day.twoone_none");
            variableNames.Add("day.nineteen_few_or_none");
            variableNames.Add("day.nineteen_many_or_all");
            variableNames.Add("rep.loyalty");
            variableNames.Add("rep.ecology");
            variableNames.Add("rep.peace");
            variableNames.Add("rep.health");
            variableNames.Add("rep.prosperity");
            variableNames.Add("rep.worst_parameter_name");
            variableNames.Add("rep.best_parameter_name");
            variableNames.Add("rep.best_parameter_value");
            variableNames.Add("rep.worst_parameter_value");
            variableNames.Add("rep.death_total");
            variableNames.Add("rep.spare_total");
            variableNames.Add("shop.keeper_hello_done");
            variableNames.Add("shop.keeper_story_mirror_done");
            variableNames.Add("shop.keeper_story_snowglobe_done");
            variableNames.Add("shop.keeper_story_desklamp_done");
            variableNames.Add("shop.keeper_story_eraser_done");
            variableNames.Add("shop.keeper_story_calendar_done");
            variableNames.Add("shop.keeper_story_cactus_done");
            variableNames.Add("shop.keeper_story_radio_done");
            variableNames.Add("shop.keeper_story_anubis_done");
            variableNames.Add("shop.keeper_story_catears_done");
            variableNames.Add("shop.keeper_story_greatoldone_done");
            variableNames.Add("shop.keeper_story_librarian_done");
            variableNames.Add("shop.keeper_story_plaguedoctor_done");
            variableNames.Add("shop.keeper_story_bonehead_done");
            variableNames.Add("shop.keeper_story_smokingman_done");
            variableNames.Add("shop.keeper_story_sugarskull_done");
            variableNames.Add("shop.keeper_story_cape_done");
            variableNames.Add("shop.keeper_story_suit_done");
            variableNames.Add("shop.keeper_story_bowtie_done");
            variableNames.Add("shop.keeper_story_toy_done");
            variableNames.Add("shop.keeper_story_lorebook_done");
            variableNames.Add("shop.keeper_story_coin_done");
            variableNames.Add("shop.keeper_story_fidget_done");
            variableNames.Add("shop.keeper_bad_sales_pitch");
            variableNames.Add("shop.keeper_heard_the_final_offer");
            variableNames.Add("shop.keeper_heard_subplot_ending");
            variableNames.Add("shop.keeper_story_oinkbank_done");
            variableNames.Add("mirror.conscience_hello_done");
            variableNames.Add("mirror.conscience_plot_point_comments_done");
            variableNames.Add("mirror.conscience_warning_ecology_done");
            variableNames.Add("mirror.conscience_warning_peace_done");
            variableNames.Add("mirror.conscience_warning_health_done");
            variableNames.Add("mirror.conscience_warning_prosperity_done");
            variableNames.Add("mirror.conscience_failure_prosperity_done");
            variableNames.Add("mirror.conscience_failure_health_done");
            variableNames.Add("mirror.conscience_failure_ecology_done");
            variableNames.Add("mirror.conscience_failure_peace_done");
            variableNames.Add("mirror.conscience_thirteen_banter_done");
            variableNames.Add("mirror.conscience_ten_chatty_done");
            variableNames.Add("mirror.conscience_failure_did_not_happen_done");
            variableNames.Add("mirror.conscience_nine_solo_done");
            variableNames.Add("mirror.conscience_seven_comments_done");
            variableNames.Add("mirror.conscience_has_left_the_building");
            variableNames.Add("mirror.conscience_has_left_once");
            variableNames.Add("mirror.conscience_eleven_chat_done");
            variableNames.Add("mirror.conscience_25_endgame_bad_done");
            variableNames.Add("mirror.conscience_25_endgame_gud_done");
            variableNames.Add("mirror.conscience_27_endgame_bad_done");
            variableNames.Add("mirror.conscience_27_endgame_gud_done");
            variableNames.Add("mirror.i_am_permanently_false_placeholder");
            variableNames.Add("mirror.conscience_fifteen_business_done");
            variableNames.Add("mirror.conscience_23_you_chat_done");
            variableNames.Add("inventory.mirror");
            variableNames.Add("inventory.snowglobe");
            variableNames.Add("inventory.anubis");
            variableNames.Add("inventory.cat_ears");
            variableNames.Add("inventory.great_old_one");
            variableNames.Add("inventory.cape");
            variableNames.Add("inventory.plague_doctor");
            variableNames.Add("inventory.smoking_man");
            variableNames.Add("inventory.sugar_skull");
            variableNames.Add("inventory.suit_bowtie");
            variableNames.Add("inventory.suit_tie");
            variableNames.Add("inventory.bonehead");
            variableNames.Add("inventory.desklamp");
            variableNames.Add("inventory.eraser");
            variableNames.Add("inventory.calendar");
            variableNames.Add("inventory.cactus");
            variableNames.Add("inventory.radio");
            variableNames.Add("inventory.librarian");
            variableNames.Add("inventory.toy_cat");
            variableNames.Add("inventory.award_plaque");
            variableNames.Add("inventory.book_lore");
            variableNames.Add("inventory.money");
            variableNames.Add("inventory.book_fate");
            variableNames.Add("inventory.coin");
            variableNames.Add("inventory.fidget_thing");
            variableNames.Add("inventory.sin_bulb");
            variableNames.Add("inventory.current_head");
            variableNames.Add("inventory.current_body");
            variableNames.Add("inventory.oinkbank");
            variableNames.Add("book.intro_done");
            variableNames.Add("book.reached_hub_1");
            variableNames.Add("book.reached_hub_2");
            variableNames.Add("book.reached_hub_3");
        }
        #endregion
        
        public intro intro
        {
            get
            {
                return mIntro;
            }
        }
        
        public game game
        {
            get
            {
                return mGame;
            }
        }
        
        public profile profile
        {
            get
            {
                return mProfile;
            }
        }
        
        public day day
        {
            get
            {
                return mDay;
            }
        }
        
        public rep rep
        {
            get
            {
                return mRep;
            }
        }
        
        public shop shop
        {
            get
            {
                return mShop;
            }
        }
        
        public mirror mirror
        {
            get
            {
                return mMirror;
            }
        }
        
        public inventory inventory
        {
            get
            {
                return mInventory;
            }
        }
        
        public book book
        {
            get
            {
                return mBook;
            }
        }
        
        public static ArticyGlobalVariables Default
        {
            get
            {
                return ((ArticyGlobalVariables)(Articy.Unity.ArticyDatabase.DefaultGlobalVariables));
            }
        }
        
        public override void Init()
        {
            intro.RegisterVariables(this);
            game.RegisterVariables(this);
            profile.RegisterVariables(this);
            day.RegisterVariables(this);
            rep.RegisterVariables(this);
            shop.RegisterVariables(this);
            mirror.RegisterVariables(this);
            inventory.RegisterVariables(this);
            book.RegisterVariables(this);
        }
    }
}
