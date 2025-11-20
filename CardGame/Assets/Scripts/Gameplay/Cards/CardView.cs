using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardView : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text descriptionText;
    public TMP_Text manaText;
    public TMP_Text healthText;
    public TMP_Text damageText;

    public void Initialize(CardInstance instance)
    {
        var def = instance.definition;

        nameText.text = def.name;
        descriptionText.text = def.description;
        manaText.text = def.mana.ToString();
        healthText.text = instance.currentHealth.ToString();
        damageText.text = instance.currentDamage.ToString();

        // Load card art (if you want)
        // artImage.sprite = Resources.Load<Sprite>("CardArt/" + def.image);
    }
}
