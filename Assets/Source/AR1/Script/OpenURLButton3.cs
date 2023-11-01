using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURLButton3 : MonoBehaviour
{
    public string url = "https://smartstore.naver.com/homesool_com/products/7861612377?n_media=27758&n_query=%EB%A7%89%EA%B1%B8%EB%A6%AC&n_rank=2&n_ad_group=grp-a001-02-000000030706098&n_ad=nad-a001-02-000000235161180&n_campaign_type=2&n_mall_id=ncp_1o86lj_01&n_mall_pid=7861612377&n_ad_group_type=2&n_match=3&NaPm=ct%3Dlodrb608%7Cci%3D0Egc001Dqi1zqhs%5FUuWX%7Ctr%3Dpla%7Chk%3Dc3dfdadf6fa18068ab80d6a1edbd97fff85cd851"; // 원하는 URL로 변경

    public void OpenURL()
    {
        Application.OpenURL(url);
    }
}
