using SkyNews.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SkyNews.ViewModels
{
    class ArticlesViewModel : BaseViewModel
    {
        public ObservableCollection<Article> Articles { get; set; }

        public ArticlesViewModel()
        {
            this.Articles = new ObservableCollection<Article>();
            //Just for tesing
            this.Articles.Add(new Article
            {
                Title = "Chelsea Manning: US whistleblower jailed for refusing to testify at WikiLeaks investigation",
                Body = "The ex-US Army intelligence analyst, who was jailed for espionage, told the judge she \"will accept whatever you bring upon me\".\n" +
                "Sending her to a federal prison on Friday, US District Judge Claude Hilton said she will remain behind bars until she testifies, or until the grand jury finishes its inquiry." +
                "The former US Army intelligence analyst told the judge she \"will accept whatever you bring upon me\"." +
                "Manning, 31, has said she objects to the secrecy of the grand jury process, and that she already revealed everything she knows at her court martial.Her lawyers had asked that she be sent to home confinement instead of jail, because of medical complications she faces." +
                "The judge said US Marshals can handle her treatment needs. Manning was convicted of espionage and other offences by court - martial in 2013."
            });
            this.Articles.Add(new Article
            {
                Title = "Facebook takes down dozens of fake accounts used to spread hate in UK",
                Body = "The pages and groups frequently changed their names to get more followers to spread hate speech and divisive comments in the UK.\n" +
                "The accounts were part of a domestic-focused network in the UK, he added.\"The individuals behind these accounts represented themselves as far-right and anti-far-right activists, frequently changed page and group names, and operated fake accounts to engage in hate speech and spread divisive comments on both sides of the political debate in the UK,\" Mr Gleicher said.\"Despite their misrepresentation of their identities, we found that these pages, groups and accounts were connected."
            });
            this.Articles.Add(new Article
            {
                Title = "Queen posts on Instagram for the first time at Science Museum exhibition launch",
                Body = "The 92-year-old makes history as she touches an iPad screen and shares photos of a letter sent to her great-great-grandfather.\n" + "She touched an iPad screen and shared images on the official Royal Family account while announcing the Science Museum's new summer exhibition, called Top Secret.\n" +
                    "Babbage, known as a pioneer of the computer, wrote to Prince Albert about his Analytical Engine - a machine that could perform calculations using punched cards. It also had a memory unit to store numbers.The Queen was applauded as she shared the post, which she signed off \"Elizabeth R\", to the Royal Family's 4.6 million followers on the photo-sharing platform.\n" +
                    "She wrote: \"In the letter, Babbage told Queen Victoria and Prince Albert about his invention, the Analytical Engine, upon which the first computer programmes were created by Ada Lovelace, a daughter of Lord Byron." +
                    "\"Today, I had the pleasure of learning about children's computer coding initiatives and it seems fitting to me that I publish this Instagram post at the Science Museum, which has long championed technology, innovation and inspired the next generation of inventors.\"\n"
            });
            this.Articles.Add(new Article
            {
                Title = "Huawei: The company and the security risks explained",
                Body = "The assessment of the Chinese state as hostile towards Western nations is key in understanding why Huawei is considered a risk.\n" + "Huawei is a Chinese business which has grown to become the world's largest telecommunications equipment vendor.\n" + "Reports of its equipment being banned as nations seek to develop their 5G networks show little sign of stopping, and Western bodies including the EU and NATO have been called on to establish a joint position on their security risks.\n" +
                    "Huawei's equipment occupies every step of the network chain between our laptops and phones through to the data centres hosting the content we want to access.\n" +
                    "Although it sells those user devices too, its equipment is especially prominent in the parts of the network closer to the data centres and it's this equipment which is raising concerns.\n" +
                    "Network switches, gateways, routers, and bridges - the kit that controls how and where data is sent - is what Huawei really does. These infrastructure devices touch everything traversing the internet and are critical to it functioning properly." +
                    "As Huawei is the biggest player in what is a critical part of modern infrastructure, it is an obvious and necessary candidate for scrutiny. In general, the results of that scrutiny have not been favourable.\n" +
                    "Three nations in the intelligence alliance Five Eyes, the US, Australia, and New Zealand, have effectively prohibited the installation of Huawei equipment as part of the next generation of telecommunications equipment.\n"
            });
            this.Articles.Add(new Article
            {
                Title = "Facebook no longer regards itself as social media",
                Body = "After arguing that privacy is no longer a \"social norm\", Mark Zuckerberg has suddenly changed his tune to mimic Snapchat's.\n" +
                "After years of copying Snapchat's products, Facebook just copied its rival's entire philosophy.\n" +
                "For almost a decade, Snapchat founder Evan Spiegel has been saying that online communication needs to be ephemeral - lasting for a short time - and based on small groups.\n" +
                "Now, after arguing that privacy is no longer a \"social norm\" (and behaving as if he believes it), Mark Zuckerberg has suddenly decided he agrees.\n" +
                "He has promised to transform privacy on Facebook with new encryption that even the site's bosses cannot penetrate.\n" +
                "Inevitably, much of the reaction to Mr Zuckerberg's announcement will concentrate on encryption, due to the difficulties it creates for law enforcement tracking suspects.\n" +
                "There will also be plenty of questions about what \"privacy\" will look like in this new Facebook, which will still be as thirsty as ever for user data." +
                "But, to my mind, the most important part of Mr Zuckerberg's essay is what it doesn't say.\n"
            });
        }
    }
}
