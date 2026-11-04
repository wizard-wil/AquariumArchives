using System;

namespace AquariumArchives.Models
{
    public class SampleData
    {
        public static List<Fish> list = new List<Fish>
        {
            new()
            {
                Id=1,
                Name = "Orca Whale",
                Description = "The orca (Orcinus orca), or killer whale, is a toothed whale and the largest member of the oceanic dolphin family. The only extant species in the genus Orcinus, it is recognizable by its distinct pigmentation; being mostly black on top, white on the bottom and having recognizable white eye patches. A cosmopolitan species, it inhabits a wide range of marine environments, from Arctic to Antarctic regions to tropical seas, but is more commonly documented in temperate or cooler coastal waters. Scientists have proposed dividing the global population into races, subspecies, or possibly even species.",
                ImageFile = "orca.jpg"
            },
            new()
            {
                Id=2,
                Name = "Mooneye",
                Description = "Hiodontidae, commonly called mooneyes, is a family of ray-finned fish with a single included genus Hiodon. The genus comprise two extant species native to North America and three to five extinct species recorded from Paleocene to Eocene age fossils. They are large-eyed, fork-tailed fish that superficially resemble shads. The vernacular name comes from the metallic shine of their eyes.",
                ImageFile = "mooneye.jpg"
            },
            new()
            {
                Id=3,
                Name = "Silver Porgy",
                Description = "Diplodus argenteus, the silver porgy, is an ocean-going species of sparid fish (seabream/porgies). It is also called the South American silver porgy and the white bream in Uruguay, plus the silver seabream and the sargo, though the latter three names are also used for other fish species as well.",
                ImageFile = "silverporgy.jpg"
            },
            new()
            {
                Id=4,
                Name = "European Seabass",
                Description = "European seabass (Dicentrarchus labrax), also known as branzino, European bass, sea bass, common bass, white bass, capemouth, white salmon, white mullet, sea dace, levrek or loup de mer, or lavraki (λαβράκι) is a primarily ocean-going fish native to the waters off Europe's western and southern and Africa's northern coasts, though it can also be found in shallow coastal waters and river mouths during the summer months and late autumn. It is one of only six species in its family, Moronidae, collectively called the temperate basses.",
                ImageFile = "europeanseabass.jpg"
            },
            new()
            {
                Id=5,
                Name = "Betta siamorientalis",
                Description = "Betta siamorientalis is a species of gourami in genus Betta. It is a freshwater fish native to Asia, where it occurs in shallow marshes, grass fields, and paddy fields in some provinces in eastern Thailand (Chacheongsao, Sa Kaeo, Prachin Buri, some part of Chon Buri) and Cambodia and southern Vietnam. It is typically found in still, vegetated environments at the water's edge and is known to use aquatic plants as shelter for building and guarding bubble nests. It is known to occur alongside the species Anabas testudineus, Lepidocephalichthys hasselti, Macrognathus siamensis, Monopterus albus, Pangio anguillaris, Trichopodus trichopterus, Trichopsis pumila, Trichopsis schalleri, and Trichopsis vittata. The species reaches 3.6 cm (1.4 inches) in standard length and is known to be a facultative air-breather",
                ImageFile = "bettasiamorientalis.jpg"
            },
            new()
            {
                Id=6,
                Name = "Chelaethiops",
                Description = "Chelaethiops is a genus of freshwater ray-finned fishes belonging to the family Danionidae, the danionins or danios. The fishes in this genus are found in lakes and rivers of Africa. While commonly called sardines, they are not related to the true sardines of the family Clupeidae.",
                ImageFile = "chelaethiops.jpg"
            },
            new()
            {
                Id=7,
                Name = "Murray Cod",
                Description = "The Murray cod (Maccullochella peelii) is a large Australian predatory freshwater fish of the genus Maccullochella in the family Percichthyidae. Although the species is called a cod in the vernacular, it is not related to the Northern Hemisphere marine cod (Gadus) species. The Murray cod is an important part of Australia's vertebrate wildlife—as an apex predator in the Murray-Darling River system—and also significant in Australia's human culture. The Murray cod is the largest exclusively freshwater fish in Australia, and one of the largest in the world. Other common names for Murray cod include cod, greenfish, goodoo, Mary River cod, Murray perch, ponde, pondi and Queensland freshwater cod.",
                ImageFile = "murraycod.jpg"
            },
            new()
            {
                Id=8,
                Name = "Ocellated icefish",
                Description = "The ocellated icefish (Chionodraco rastrospinosus) is a fish belonging to the Channichthyidae family. It lives in the cold waters off Antarctica and is known for having transparent haemoglobin-free blood.",
                ImageFile = "ocellatedicefish.jpg"
            },
            new()
            {
                Id=9,
                Name = "Flapjack Octopus",
                Description = "Opisthoteuthis californiana, also known as the flapjack octopus or flapjack devilfish, is a species of umbrella octopus. Flapjack octopuses usually appear pinkish, possessing a gelatinous body. They have fins above their eyes, similar to those found on some species of squid. Their maximum size is 20 cm (7.9 in) mantle length. They have eight arms (like any other octopus), but these are joined together by a membrane or \"webbing\", forming an umbrella-like shape; these webbed arms are spread into a parachute-like shape when maneuvering through dimly lit water. Unlike commonly known octopus which live in shallower waters, they are unable to camouflage by changing skin color and texture. They swim by moving their fins, pulsing their webbed arms, pushing water through their funnel for jet propulsion, or all three at once.",
                ImageFile = "flapjackoctopus.jpg"
            },
            new()
            {
                Id=10,
                Name = "Lemon Shark",
                Description = "The lemon shark (Negaprion brevirostris) is a species of requiem shark from the family Carcharhinidae, known for its yellowish skin, which inspires its common name. Lemon sharks can grow to 3.4 m (11 ft) in length. They are often found in shallow subtropical waters and are known to inhabit and return to specific nursery sites for breeding. Often feeding at night, these sharks use electroreceptors to find their main source of prey, fish. Lemon sharks enjoy the many benefits of group living, such as enhanced communication, courtship, predatory behavior, and protection.",
                ImageFile = "lemonshark.jpg"
            },
            new()
            {
                Id=11,
                Name = "Leopard Shark",
                Description = "The leopard shark (Triakis semifasciata) is a species of houndshark, in the family Triakidae. It is found along the Pacific coast of North America, from the U.S. state of Oregon to Mazatlán in Mexico. Typically measuring 1.2–1.5 m (3.9–4.9 ft) long, this slender-bodied shark is immediately identifiable by the striking pattern of black saddle-like markings and large spots over its back, from which it derives its common name. Large schools of leopard sharks are a common sight in bays and estuaries, swimming over sandy or muddy flats or rock-strewn areas near kelp beds and reefs. They are most common near the coast, in water less than 4 m (13 ft) deep.",
                ImageFile = "leopardshark.jpg"
            }
        };
        public static List<string> Facts = new()
        {
            "The most often quoted estimate of the number of fish species is 20,000. There may be as many as 20,000 more",
            "The largest fish in the world ... is actually a shark. Specifically, the whale shark, which grows to more than 50 feet long and may weigh several tons.",
            "The second largest fish is the basking shark, which can measure 35 to 40 feet long",
            "The smallest fish is the tiny goby, which lives in the Philippines. It rarely grows longer than half an inch at adulthood, yet is so abundant it supports a fishery.",
            "The most common fish is any of the species of a deepwater fish sometimes called a \"bristle mouth.\" The fish is about the size of a small minnow. It is caught at 500 meters or deeper all over the world",
            "The oldest fish-like animals are those with sucking mouths, like lampreys and hagfish. They stopped evolving before the development of biting jaws.",
            "Scientists can figure out how old a fish is by counting growth rings on its scales or its ear bones (called \"otoliths\"). The rings mark seasonal changes in fish growth, like the annual rings in tree trunks.",
            "Otoliths grow like pearls, but the added material changes color depending on the season. The summer ring is whiter and the winter ring is thinner and more translucent.",
            "In scales, a series of fine rings appear as the scale grows. In summer the rings are wider apart. In winter the rings are closer together, because the fish grow more slowly. Each pair of rings indicates one year.",
            "The orange roughy lives more than 100 years. In the Northwest Atlantic, the longest-lived fish is the Acadian redfish, which can live past 40 years. How long a fish lives depends on its species.",
            "Fish breathe oxygen, not air. Their gills contain a network of fine blood vessels that diffuse the oxygen throughout the fish's membranes.",
            "The dictionary defines sleep as a recurrent period of rest in which the nervous system is inactive, the eyes closed. Most fish don't have eyelids (except for sharks).",
            "Many fish live nearly motionless lives. But most fish rest. Some float in place, some wedge themselves into a spot in the mud or the coral, some even build themselves a nest. They are still alert for danger, but they are also \"sleeping.\"",
            "Fish swim primarily by contracting bands of muscles in sequence on alternate sides of the body. This whips the tail very rapidly from side to side in a sculling motion. ",
            "Vertical fins are used mainly for stabilization. Paired pectoral and pelvic fins are used primarily for stability when a fish hovers. Sometimes fish might use them to aid rapid forward motion.",
            "Tunas and tuna-like fish, billfish, and certain sharks are the speed champions. They can reach 50 miles per hour in short bursts. Sustained swimming speeds generally range from about 5 to 10 miles per hour among strong swimmers",
            "A number of fish species can swim backwards, but usually don't. Those that can are mostly members of one of the eel families.",
            "Most fish swim in the horizontal position. The sea horse is among the exceptions. Another is the shrimp fish of the Indian Ocean, which congregates in schools of several individuals. It swims vertically, its long tube-like snout pointing directly upward. A catfish that lives in the Nile and other African rivers also swims in the vertical posture. Many kinds of midwater deepsea fish swim or rest vertically.",
            "Fish would suffocate if they tried to chew their food. Chewing would interfere with the passage of water over the gills, necessary for obtaining oxygen.",
            "Carnivorous fish like sharks use their sharp teeth to seize and hold prey while swallowing it whole or in large pieces.",
            "Bottom dwellers such as rays are equipped with large flat teeth that crush the shellfish they consume.",
            "Herbivorous fish (grazers) often lack jaw teeth, but have tooth-like grinding mills in their throats, called pharyngeal teeth.",
            "Most kinds of fish encountered by anglers are edible. The organs of some species are always poisonous to man. Fish can become toxic because of elements in their diets.",
            "More than 240 species contain so little salt that doctors recommend them in salt-free diets",
            "Shark meat is salty—as salty as the sea the shark lives in.",
            "For most species, truly fresh fish is almost odorless. Fish begin to smell \"fishy\" when it starts to deteriorate, usually when it isn't stored or preserved correctly.",
            "If fish caught with artificial lures are handled carefully, most will survive.",
            "Fish are cold-blooded vertebrates that live wholly in water.",
            "Fish comes in all sizes, shapes, and forms. They can also be found in different bodies of water like the ocean, rivers, lakes, and ponds. Whatever differences there are that may exist, however, there are general features that define them and make them who they are.",
            "Fish can walk, and it’s more common than you probably think. Scientists believe that there are at least 11 fish species in the world that have the ability to walk. The majority is limited to the seafloor, but some can also stroll on land above the water. ",
            "Electric Eels are known for their ability to produce electricity. They can generate more than 800 volts, which is enough to light up several LED bulbs for a few seconds. It’s also the highest voltage an animal can release.",
            "Much like a bear can smell a distant carcass, fish can sense the movement of an underwater creature from miles away. How? Using an organ called the lateral line.",
            "Archerfish, famous for recognizing human faces, hunt by spitting – the same and quite precise method they used to tell humans on the computer apart (more on that later). They release a powerful stream of water from their mouths and hit insects, spiders, and even small animals that they notice on the plants above the water.",
            "Yellowjacket Cichlid pretend to be dead, so that they can attract smaller fish to feast on their bodies. And when their guests don’t suspect anything, they spring back to life and snatch them!",
            "Depending on where in the water column they’re hunting, fish mouths can be upward-facing (superior), downward-facing (inferior), or forward-facing (terminal).",
            "Fish most certainly can produce various sounds we can interpret as singing. Grunting, croaking, humming, drumming… Fish have their own acoustic language, which they use to communicate different things, from courting to warning. ",
            "Barracudas have needle-like teeth, hunt by sight, and contain high ciguatoxin levels.",
            "Bluefish get their name from their blue skin. If you cut one open, the meat has a blue tinge to it as well. They’re a widely distributed fish, found everywhere except for the Northern Pacific Ocean.",
            "Trout are some of the most adaptable fish in the world. Many species spend time in saltwater, then move to freshwater to spawn. Some saltwater species have adapted to freshwater environments completely. ",
            "Carp are freshwater fish native to Europe and Asia. In North America, Africa, and Australia, they’re considered invasive species. They have small, downward-facing mouths. Carp are omnivores, eating plants, plankton, worms, and insects",
            "Catfish get their name from the barbels on their face. Those barbels look like whiskers, and like whiskers, are very sensitive. They help catfish sense vibrations in low visibility water."
        };
    }
}

